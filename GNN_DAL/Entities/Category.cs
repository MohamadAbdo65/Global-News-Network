using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GNN_DAL.Entities;

public partial class Category
{
    [Key]
    public int CategoryID { get; set; }

    [StringLength(50)]
    public string CategoryName { get; set; } = null!;

    public int Category_BinaryN { get; set; }

    public string? ImagePath { get; set; }
}
