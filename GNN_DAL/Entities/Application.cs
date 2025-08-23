using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GNN_DAL.Entities;

public partial class Application
{
    [Key]
    public int ApplicationID { get; set; }

    [StringLength(120)]
    public string NewsAgencyName { get; set; } = null!;

    public int NewsAgencyCountryID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FoundDate { get; set; }

    public string? Image { get; set; }

    public int ApplicantJournalistID { get; set; }

    /// <summary>
    /// 1 = Review | 2 = Accepted | 3 = Rejected | 4 = Cancelled
    /// </summary>
    public byte ApplicationStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ApplicationDate { get; set; }

    [ForeignKey("ApplicantJournalistID")]
    [InverseProperty("Applications")]
    public virtual Journalist ApplicantJournalist { get; set; } = null!;

    [ForeignKey("NewsAgencyCountryID")]
    [InverseProperty("Applications")]
    public virtual Country NewsAgencyCountry { get; set; } = null!;
}
