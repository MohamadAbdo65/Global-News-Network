using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GNN_DAL.Entities;

public partial class Event
{
    [Key]
    public int EventID { get; set; }

    [StringLength(100)]
    public string EventName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime EventStartDate { get; set; }

    [InverseProperty("Event")]
    public virtual ICollection<EventsNews> EventsNews { get; set; } = new List<EventsNews>();
}
