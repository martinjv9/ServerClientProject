using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StinkyModule;

[Table("City")]
public partial class City
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    public decimal Lat { get; set; }

    public decimal Lon { get; set; }

    [Column("population")]
    public int Population { get; set; }

    [Column("countryID")]
    public int CountryId { get; set; }

    [ForeignKey("CountryId")]
    [InverseProperty("Cities")]
    public virtual Country Country { get; set; } = null!;
}
