using System;
using System.Collections;

namespace HelloWorld
{
    class Program
    {
         class Member
        {
            public int ID { get; set;}
            public string FirstName { get; set; } 
            public string LastName { get; set; }
            public string Gendar { get; set; }        
            public DateTime DateOfBirth { get; set; }
            public string PhoneNumber { get; set; }
            public string BirthPlace { get; set; }
            public int Age { get; set; }
            public Boolean Isgraduted { get; set; }
            public List<Member> ListMember = null;

            //1.Return a list of members who is Male
            public List<Member> maleMember()
            {
                List<Member> maleMember = new List<Member>();
                foreach (Member mb in ListMember)
                {
                    if(mb.Gendar == "Nam")
                    {
                        maleMember.Add(mb);
                    }
                }
                return maleMember;
            }
            //2.Return the oldest one based on "Age" 
            public int oldestAge()
            {
                int OldestAge = 0;
                DateTime today = DateTime.Now;
                int year = today.Year;

                foreach (Member mb in ListMember)
                {
                    if (year - mb.DateOfBirth.Year > OldestAge )
                    {
                        OldestAge = year - mb.DateOfBirth.Year;
                    }
                }
                return OldestAge;
            }
            //3.Return a new list that contains FullName 
            public List<string> fullNameMember()
            {
                string fn;
                var FullNameMember = new List<string>();
                foreach(Member mb in ListMember)
                {
                    fn = mb.FirstName + " " + mb.LastName;
                    FullNameMember.Add(fn);
                }    
                return FullNameMember;
            }
            //4.Return 3 list: List of members who has birth year is 2000 or greater than 200 or less than 2000
            public List<Member> birthYearMember()
            {
                List<Member> Members1 = new List<Member>();
                List<Member> Members2 = new List<Member>();
                List<Member> Members3 = new List<Member>();
                foreach(Member mb in ListMember)
                {
                    int year = (int)mb.DateOfBirth.Year;
                    switch(year)
                    {
                        case > 2000:
                            Members2.Add(mb);
                            break;
                        case < 2000:
                            Members3.Add(mb);
                            break;
                        default:
                            Members1.Add(mb);
                            break;
                    }    
                } 
            }
            //5.Return the first person who was born in Ha Noi.
            public List<Member> firstPerson()
            {
                List<Member> FirstPerson = new List<Member>();
                foreach(Member mb in ListMember)
                {
                    while (mb.BirthPlace == "Ha Noi")
                    {
                        FirstPerson.Add(mb);
                        break;
                    }
                }
                return FirstPerson;
            }
        }
        static void Main(string[] args)
        {
            List<Member> members = new List<Member>()
            {
            };
        }
    }
}
