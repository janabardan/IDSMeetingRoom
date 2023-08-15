using System;
using System.Collections.Generic;

namespace IDS.Core.Models;

public partial class Company
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Email { get; set; } = null!;

    public string? Logo { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
