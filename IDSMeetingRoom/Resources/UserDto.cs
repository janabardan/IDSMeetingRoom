﻿namespace IDSMeetingRoom.Resources
{
    public class UserDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public DateTime Dob { get; set; }

        public bool Gender { get; set; }

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;

        public int CompanyId { get; set; }

        public string Role { get; set; } = null!;
    }
}
