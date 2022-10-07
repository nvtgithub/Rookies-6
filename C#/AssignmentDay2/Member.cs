using System;
namespace Assignment
{
    public class Member
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string? BirthPlace { get; set; }
        public uint Age
        {
            get
            {
                return (uint)(DateTime.Now.Year - DateOfBirth.Year);
            }
        }
        public bool IsGraduted { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public Member(string fName, string lName, string gender, DateTime dateOfBirth,
                       string phoneNumber, string birthPlace, bool isGraduted)
        {
            FirstName = fName;
            LastName = lName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            BirthPlace = birthPlace;
            IsGraduted = isGraduted;
        }
        public string Info
        {
            get
            {
                string graduted = (IsGraduted) ? "IsGraduted" : "Not Graduted";
                return FirstName + " - " + LastName + " | " + Gender + " | " + DateOfBirth.ToString("dd/mm/yy")
                + " | " + PhoneNumber + " | " + BirthPlace + " | " + Age.ToString() + " | " + graduted;
            }
        }
    }
}