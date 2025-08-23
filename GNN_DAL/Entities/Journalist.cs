using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GNN_DAL.Entities;

public partial class Journalist
{
    [Key]
    public int JournalistsID { get; set; }

    public int UserID { get; set; }

    public int? NewsAgencyID { get; set; }

    public byte YearsExp { get; set; }

    [InverseProperty("ApplicantJournalist")]
    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();

    [InverseProperty("Journalist")]
    public virtual ICollection<News> News { get; set; } = new List<News>();

    [ForeignKey("NewsAgencyID")]
    [InverseProperty("Journalists")]
    public virtual NewsAgency? NewsAgency { get; set; }

    [InverseProperty("Journalist")]
    public virtual ICollection<Story> Stories { get; set; } = new List<Story>();

    [ForeignKey("UserID")]
    [InverseProperty("Journalists")]
    public virtual User User { get; set; } = null!;
}
