using System;
namespace Assignment
{
    public class Member
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gendar { get; set; }
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
        public Member(string fName, string lName, string gendar, DateTime dateOfBirth,
         string phoneNumber, string birthPlace, bool isGraduted)
        {
            FirstName = fName;
            LastName = lName;
            Gendar = gendar;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            BirthPlace = birthPlace;
            IsGraduted = isGraduted;
        }
        public override string ToString()
        {
            return FirstName + " - " + LastName + " | " + Gendar + " | " + DateOfBirth.ToString("dd/mm/yy")
            + " | " + PhoneNumber + " | " + BirthPlace + " | " + Age.ToString() + " | " + IsGraduted;
        }
    }
}