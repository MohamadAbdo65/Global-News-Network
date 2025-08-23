using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GNN_DAL.Entities;

[Keyless]
public partial class CountriesOfNews
{
    public int ID { get; set; }

    public int NewsID { get; set; }

    public int CountryID { get; set; }

    [ForeignKey("CountryID")]
    public virtual Country Country { get; set; } = null!;

    [ForeignKey("NewsID")]
    public virtual News News { get; set; } = null!;
}
