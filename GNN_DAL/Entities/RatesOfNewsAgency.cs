using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GNN_DAL.Entities;

public partial class RatesOfNewsAgency
{
    [Key]
    public int RateID { get; set; }

    public int UserID { get; set; }

    public int AgencyID { get; set; }

    public byte Rate { get; set; }

    [ForeignKey("AgencyID")]
    [InverseProperty("RatesOfNewsAgencies")]
    public virtual NewsAgency Agency { get; set; } = null!;

    [ForeignKey("UserID")]
    [InverseProperty("RatesOfNewsAgencies")]
    public virtual User User { get; set; } = null!;
}
