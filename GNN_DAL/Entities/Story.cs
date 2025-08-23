using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GNN_DAL.Entities;

public partial class Story
{
    [Key]
    public int StoryID { get; set; }

    public string StoryTitle { get; set; } = null!;

    public string StoryContent { get; set; } = null!;

    public int Catagories_Binary { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PublishDateTime { get; set; }

    public int JournalistID { get; set; }

    public int CountReadings { get; set; }

    public string? Image { get; set; }

    public int NumberMinuteToReading { get; set; }

    [ForeignKey("JournalistID")]
    [InverseProperty("Stories")]
    public virtual Journalist Journalist { get; set; } = null!;
}
