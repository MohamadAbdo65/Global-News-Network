using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GNN_DAL.Entities;

public partial class Comment
{
    [Key]
    public int CommentID { get; set; }

    public int PersonID { get; set; }

    public int NewsID { get; set; }

    public string CommentContent { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime PublishDate { get; set; }

    [ForeignKey("NewsID")]
    [InverseProperty("Comments")]
    public virtual News News { get; set; } = null!;

    [ForeignKey("PersonID")]
    [InverseProperty("Comments")]
    public virtual Person Person { get; set; } = null!;
}
