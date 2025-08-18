using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ArkCRM.Models;

public partial class Customer
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    [StringLength(20)]
    public string? TelephoneNumber { get; set; }

    [StringLength(100)]
    public string? ContactPersonName { get; set; }

    [StringLength(255)]
    public string? ContactPersonEmail { get; set; }

    [StringLength(20)]
    public string? VatNumber { get; set; }
}
