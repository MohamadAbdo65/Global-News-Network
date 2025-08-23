using Data_GlobalNewsNetwork;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_GlobalNewsNetwork
{
    public class clsBookmarks
    {       
        public static DataTable GetAllBookmarksForUser(int UserID)
        {
            return clsDataBookmarks.GetAllBookmarksForUser(UserID);
        }

        public static int AddBookmark(int UserID , int NewsID)
        {
            int BookMarkID = -1;

            if (clsDataBookmarks.AddInBookmarks(ref BookMarkID, UserID, NewsID, DateTime.Now))
                return BookMarkID;

            return -1;
        }

        public static bool DeleteBookmark(int UserID , int NewsID)
        {
            return clsDataBookmarks.DeleteInBookmarksByUserID(UserID, NewsID);
        }

        public static bool BookmarkIsExist(int UserID , int NewsID)
        {
            return clsDataBookmarks.BookmarksIsExistByUserID(UserID, NewsID);
        }
    }
}
