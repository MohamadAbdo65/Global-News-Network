using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GNN_DAL.Entities;

public partial class User
{
    [Key]
    public int UserID { get; set; }

    public int PersonID { get; set; }

    public int Catagories_Binary { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<Admin> Admins { get; set; } = new List<Admin>();

    [InverseProperty("User")]
    public virtual ICollection<Bookmark> Bookmarks { get; set; } = new List<Bookmark>();

    [InverseProperty("User")]
    public virtual ICollection<Journalist> Journalists { get; set; } = new List<Journalist>();

    [ForeignKey("PersonID")]
    [InverseProperty("Users")]
    public virtual Person Person { get; set; } = null!;

    [InverseProperty("User")]
    public virtual ICollection<RatesOfNewsAgency> RatesOfNewsAgencies { get; set; } = new List<RatesOfNewsAgency>();

    [InverseProperty("User")]
    public virtual ICollection<Technician> Technicians { get; set; } = new List<Technician>();
}
