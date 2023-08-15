namespace IDSMeetingRoom.Resources
{
    public class ReservationDto
    {

        public int Id { get; set; }

        public DateTime DateOfMeeting { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int RelatedRoom { get; set; }

        public int AttendeeNum { get; set; }

        public bool MeetingStatus { get; set; }


    }
}
