using System;
using System.Collections.Generic;

namespace IDS.Core.Models;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime Dob { get; set; }

    public bool Gender { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Role { get; set; } = null!;

    public int? CompanyId { get; set; }

    public virtual Company? Company { get; set; }

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
