using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var memberList = new List<Member>();

            memberList.Add(new Member("Tien", "Nguyen", "Male", new DateTime(2001, 2, 23), "0147258369", "Ha Noi", true));
            memberList.Add(new Member("Anh", "Nguyen", "Female", new DateTime(2000, 2, 23), "0147258369", "Ha Noi", true));
            memberList.Add(new Member("Tung", "Nguyen", "Male", new DateTime(1999, 2, 23), "0147258369", "Hai Duong", false));

            //1.Return a list of members who is Male
            Console.WriteLine("\n1.Return a list of members who is Male: ");
            var maleMember = from member in memberList
                       where member.Gendar == "Male"
                       select member;

            foreach (var member in maleMember)
            {
                Console.WriteLine(member.Info);
            }

            //2.Return the oldest on base "Age"
            Console.WriteLine("\n2.Return the oldest on base 'Age': ");
            var maxAge = memberList.Max(member => member.Age);
            var oldestAge = memberList.Find(member => member.Age == maxAge);

            if (oldestAge != null)
            {
                Console.WriteLine(oldestAge.Info);
            }

            //3.Return a new list that contains Full Name = Last Name + First Name
            Console.WriteLine("\n3.Return a new list that contains Full Name = Last Name + First Name");
            var listFullName = (from member in memberList
                                select new { FullName = member.FirstName + " " + member.LastName }).ToList();

            listFullName.ForEach(x => Console.WriteLine(x.FullName));

            //4.Return 3 list of members who has birth year is 2000 or greaterthan 2000 or lessthan 2000
            Console.WriteLine("\nReturn 3 list of members who has birth year is 2000 or greaterthan 2000 or lessthan 2000: ");
            uint option = 0;

            do
            {
                option = Convert.ToUInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("\nList of members have birth year = 2000: ");
                            var born2000 = memberList.FindAll(member => member.DateOfBirth.Year == 2000);

                            if (born2000 != null)
                            {
                                foreach (var member in born2000)
                                {
                                    Console.WriteLine(member.Info);
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\nList of members have birth year > 2000: ");
                            var bornAfter2000 = memberList.TakeWhile(member => member.DateOfBirth.Year > 2000);

                            if (bornAfter2000.Any())
                            {
                                foreach (var member in bornAfter2000)
                                {
                                    Console.WriteLine(member.Info);
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\nList of members have birth year < 2000: ");
                            var bornBefore2000 = memberList.Where(member => member.DateOfBirth.Year < 2000);

                            if (bornBefore2000.Any())
                            {
                                foreach (var member in bornBefore2000)
                                {
                                    Console.WriteLine(member.Info);
                                }
                            }
                            break;
                        }
                }
            } while (option >= 1 && option <= 3);

            //5.Return the first person who was born in Ha Noi
            Console.WriteLine("\n5.Return the first person who was born in Ha Noi: ");
            var firstPerson = (from member in memberList
                               where member.BirthPlace.ToUpper() == "HA NOI"
                               select member).Skip(0).Take(1).FirstOrDefault();

            if (firstPerson != null)
            {
                Console.WriteLine(firstPerson.Info);
            }
        }
    }
}