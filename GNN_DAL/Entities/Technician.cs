using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GNN_DAL.Entities;

public partial class Technician
{
    [Key]
    public int TechnicalID { get; set; }

    public int UserID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime JoinDate { get; set; }

    public int Permissions_Binary { get; set; }

    [ForeignKey("UserID")]
    [InverseProperty("Technicians")]
    public virtual User User { get; set; } = null!;
}
