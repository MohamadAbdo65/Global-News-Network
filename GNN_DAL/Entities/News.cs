using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GNN_DAL.Entities;

public partial class News
{
    [Key]
    public int NewsID { get; set; }

    public int JournalistID { get; set; }

    public string NewsTitle { get; set; } = null!;

    public string NewsContent { get; set; } = null!;

    public int NewsCatagories_Binary { get; set; }

    public int? CountryID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PublishDateTime { get; set; }

    public string? Image { get; set; }

    public int CountView { get; set; }

    [InverseProperty("News")]
    public virtual ICollection<Bookmark> Bookmarks { get; set; } = new List<Bookmark>();

    [InverseProperty("News")]
    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    [ForeignKey("CountryID")]
    [InverseProperty("News")]
    public virtual Country? Country { get; set; }

    [InverseProperty("News")]
    public virtual ICollection<EventsNews> EventsNews { get; set; } = new List<EventsNews>();

    [ForeignKey("JournalistID")]
    [InverseProperty("News")]
    public virtual Journalist Journalist { get; set; } = null!;
}
