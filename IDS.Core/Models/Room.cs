using System;
using System.Collections.Generic;

namespace IDS.Core.Models;

public partial class Room
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Location { get; set; } = null!;

    public int Capacity { get; set; }

    public string? Description { get; set; }

    public int? RelatedCompany { get; set; }

    public virtual Company? RelatedCompanyNavigation { get; set; }

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
