using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GNN_DAL.Entities;

public partial class Person
{
    [Key]
    public int PersonID { get; set; }

    [StringLength(50)]
    public string FirstName { get; set; } = null!;

    [StringLength(50)]
    public string LastName { get; set; } = null!;

    public bool Gender { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateOfBirth { get; set; }

    public int CountryID { get; set; }

    [StringLength(64)]
    public string Email { get; set; } = null!;

    [StringLength(64)]
    public string Password { get; set; } = null!;

    public string? Image { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateOfCreateAccount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateOfLastLogin { get; set; }

    [InverseProperty("Person")]
    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    [ForeignKey("CountryID")]
    [InverseProperty("People")]
    public virtual Country Country { get; set; } = null!;

    [InverseProperty("Person")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
