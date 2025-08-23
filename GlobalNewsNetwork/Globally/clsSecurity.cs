using System;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace GlobalNewsNetwork.Globally
{
    public static class clsSecurity
    {
        public enum enPasswordStrength { Weak, Medium, Strong }
        public static enPasswordStrength CheckPasswordStrength(string Password)
        {
            byte Score = 0;

            // 1 long
            if (Password.Length >= 12)
                Score += 2;
            else if (Password.Length >= 8)
                Score += 1;


            // 2 small and capital 
            if (Regex.IsMatch(Password, @"[a-z]") && Regex.IsMatch(Password, @"[A-Z]"))
                Score += 1;

            // 3 numbers
            if (Regex.IsMatch(Password, @"\d"))
                Score += 1;

            // 4 Symbols
            if (Regex.IsMatch(Password, @"[\W_]"))
                Score += 1;


            HashSet<string> CommonPasswords = new HashSet<string>
            {
                 "123456", "password", "12345678", "qwerty", "12345",
                 "123456789", "letmein", "123123", "welcome", "admin",
                 "password1", "abc123", "qwerty123", "iloveyou", "sunshine",
                 "111111", "1234", "000000", "superman", "football",
                 "whatever", "hello123", "access", "monkey", "login"
            };


            if (CommonPasswords.Contains(Password))
            {
                Score = 0;
            }
            

            if (Score >= 5)
                return enPasswordStrength.Strong;
            else if (Score >= 3)
                return enPasswordStrength.Medium;
            else
                return enPasswordStrength.Weak;
        }

        //*-*-*-

        /// <summary>
        /// This method for encryption password
        /// </summary>
        /// <param name="Password">Entered password (from user)</param>
        /// <returns>Encrypted password</returns>
        public static string GetEncryptionPassword(string Password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // تحويل النص إلى مصفوفة بايت
                byte[] inputBytes = Encoding.UTF8.GetBytes(Password);

                // حساب التجزئة
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                // تحويل التجزئة إلى نص مكون من أرقام وحروف (Hexadecimal)
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2")); // "x2" لتحويل كل بايت إلى رقمين عشريين
                }

                return sb.ToString();
            }
        }

        //*-*-*-

        public enum enImageType { PersonalImage , NewsImage /* ets ...*/}

        private static string PersonalImagesFolderPath
        { get { return @"D:\Global News Network Project\PersonalImages\"; } }
        private static string NewsImagesFolderPath
        {
            get { return @"D:\Global News Network Project\NewsImages\"; }
        }

        private static string KeyOfEncryptionImages
        {
            get { return "0944365Mo#123456"; }
        }

        private static void CreateFolderIfNotExist(string FolderPath)
        {
            if (!File.Exists(FolderPath))
            {
                File.Create(FolderPath);            
            }
        }
        private static string ReplaceFileNameWithGuid(string filepath)
        {
            string Ext = Path.GetExtension(filepath);
            Guid G = Guid.NewGuid();
            return  G.ToString() + Ext;
        }


        private static void EncryptImage(string inputFile, string outputFile, string key)
        {
            byte[] iv;
            using (Aes aesAlg = Aes.Create())
            {
                iv = aesAlg.IV;
            }


            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = System.Text.Encoding.UTF8.GetBytes(key);
                aesAlg.IV = iv;


                using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))

                using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))

                using (ICryptoTransform encryptor = aesAlg.CreateEncryptor())

                using (CryptoStream cryptoStream = new CryptoStream(fsOutput, encryptor, CryptoStreamMode.Write))
                {
                    // Write the IV to the beginning of the file
                    fsOutput.Write(iv, 0, iv.Length);
                    fsInput.CopyTo(cryptoStream);
                }
            }
            File.Delete(inputFile);
        }

        private static Image DecryptImageToMemory(string inputFile, string key)
        {
            if(inputFile == "")
                return null;

            // تحويل المفتاح إلى مصفوفة بايتات
            byte[] keyBytes = System.Text.Encoding.UTF8.GetBytes(key);

            using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
            {
                // قراءة الـ IV (أول 16 بايت من الملف)
                byte[] iv = new byte[16];
                int bytesRead = fsInput.Read(iv, 0, iv.Length);
                if (bytesRead != iv.Length)
                    throw new InvalidDataException("Failed to read the IV from the encrypted file.");

                // إعداد AES لفك التشفير
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = keyBytes;
                    aesAlg.IV = iv;

                    // إنشاء دالة فك التشفير
                    using (ICryptoTransform decryptor = aesAlg.CreateDecryptor())
                    using (CryptoStream cryptoStream = new CryptoStream(fsInput, decryptor, CryptoStreamMode.Read))
                    using (MemoryStream msOutput = new MemoryStream())
                    {
                        // نسخ البيانات المفككة إلى MemoryStream
                        cryptoStream.CopyTo(msOutput);

                        // إعادة الصورة من البيانات المفككة
                        msOutput.Position = 0; // إعادة مؤشر القراءة إلى البداية
                        return Image.FromStream(msOutput);
                    }
                }
            }
        }



        /// <summary>
        /// This method for store image and encryption it
        /// </summary>
        /// <param name="ImageType">Select image type for store it in the appropriate file</param>
        /// <param name="ImagePath">The path entered by the user</param>
        /// <returns>New path to the image for store it in database</returns>
        public static string StoreAndEncryptionImage(enImageType ImageType, string OldImagePath)
        {
            string PathImageWithoutEncryption = "";

            if (ImageType == enImageType.NewsImage)
            {
                PathImageWithoutEncryption = NewsImagesFolderPath + Path.GetFileName(OldImagePath);
                //CreateFolderIfNotExist(NewsImagesFolderPath);
                File.Copy(OldImagePath, PathImageWithoutEncryption, true);
            }
            else if (ImageType == enImageType.PersonalImage)
            {
                PathImageWithoutEncryption = PersonalImagesFolderPath + Path.GetFileName(OldImagePath);
                //CreateFolderIfNotExist(PersonalImagesFolderPath);
                File.Copy(OldImagePath, PathImageWithoutEncryption, true);
            }

            string InputImage = PathImageWithoutEncryption;
            string EncryptedImagePath = PersonalImagesFolderPath + ReplaceFileNameWithGuid(PathImageWithoutEncryption);

            EncryptImage(InputImage, EncryptedImagePath, KeyOfEncryptionImages);

            return EncryptedImagePath;
        }


        public static Image GetDectyptionImage(string ImagePath)
        {
            return DecryptImageToMemory(ImagePath, KeyOfEncryptionImages);
        }






















    }
}
