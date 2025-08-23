using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GNN_DAL.Entities;

public partial class Bookmark
{
    [Key]
    public int BookmarkID { get; set; }

    public int UserID { get; set; }

    public int NewsID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SaveDate { get; set; }

    [ForeignKey("NewsID")]
    [InverseProperty("Bookmarks")]
    public virtual News News { get; set; } = null!;

    [ForeignKey("UserID")]
    [InverseProperty("Bookmarks")]
    public virtual User User { get; set; } = null!;
}
