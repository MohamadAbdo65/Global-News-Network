using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GNN_DAL.Entities;

public partial class EventsNews
{
    [Key]
    public int EventNewsID { get; set; }

    public int EventID { get; set; }

    public int NewsID { get; set; }

    [ForeignKey("EventID")]
    [InverseProperty("EventsNews")]
    public virtual Event Event { get; set; } = null!;

    [ForeignKey("NewsID")]
    [InverseProperty("EventsNews")]
    public virtual News News { get; set; } = null!;
}
