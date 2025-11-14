using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WorldModel;
//City class
[Table("City")]
public partial class City
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("lat")]
    [StringLength(10)]
    public string Lat { get; set; } = null!;

    [Column("lng")]
    [StringLength(10)]
    public string Lng { get; set; } = null!;

    [Column("population")]
    public int Population { get; set; }
}
