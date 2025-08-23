using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GNN_DAL.Entities;

public partial class Country
{
    [Key]
    public int CountryID { get; set; }

    [StringLength(50)]
    public string CountryName { get; set; } = null!;

    [InverseProperty("NewsAgencyCountry")]
    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();

    [InverseProperty("Country")]
    public virtual ICollection<News> News { get; set; } = new List<News>();

    [InverseProperty("Country")]
    public virtual ICollection<NewsAgency> NewsAgencies { get; set; } = new List<NewsAgency>();

    [InverseProperty("Country")]
    public virtual ICollection<Person> People { get; set; } = new List<Person>();
}
