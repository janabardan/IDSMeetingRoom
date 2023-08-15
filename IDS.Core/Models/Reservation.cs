using System;
using System.Collections.Generic;

namespace IDS.Core.Models;

public partial class Reservation
{
    public int Id { get; set; }

    public DateTime DateOfMeeting { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public int AttendeeNum { get; set; }

    public bool MeetingStatus { get; set; }

    public int? RelatedRoom { get; set; }

    public int? RelatedUser { get; set; }

    public virtual Room? RelatedRoomNavigation { get; set; }

    public virtual User? RelatedUserNavigation { get; set; }
}
