using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GNN_DAL.Entities;

public partial class NewsAgency
{
    [Key]
    public int NewsAgencyID { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    public int CountryID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FoundDate { get; set; }

    public string Image { get; set; } = null!;

    [ForeignKey("CountryID")]
    [InverseProperty("NewsAgencies")]
    public virtual Country Country { get; set; } = null!;

    [InverseProperty("NewsAgency")]
    public virtual ICollection<Journalist> Journalists { get; set; } = new List<Journalist>();

    [InverseProperty("Agency")]
    public virtual ICollection<RatesOfNewsAgency> RatesOfNewsAgencies { get; set; } = new List<RatesOfNewsAgency>();
}
