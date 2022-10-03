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

            memberList.Add(new Member("Tien", "Nguyen", "Male", new DateTime(2001, 2, 23), "0147258369", "Ha Noi", false));
            memberList.Add(new Member("Anh", "Nguyen", "Female", new DateTime(2000, 2, 23), "0147258369", "Ha Noi", true));
            memberList.Add(new Member("Tung", "Nguyen", "Male", new DateTime(1999, 2, 23), "0147258369", "Hai Duong", false));

            //1.Return a list of members who is Male
            Console.WriteLine("\n1.Return a list of members who is Male: ");
            var query1 = from m in memberList
                         where m.Gendar == "Male"
                         select m;
            foreach (var maleMember in query1)
            {
                Console.WriteLine(maleMember.ToString());
            }

            //2.Return the oldest on base "Age"
            Console.WriteLine("\n2.Return the oldest on base 'Age': ");

            uint maxAge = 0;

            var query2 = from m in memberList
                         select new { max = memberList.Max(x => x.Age), };

            foreach (var q in query2)
            {
                maxAge = q.max;
                break;
            }

            foreach (Member m in memberList)
            {
                if (m.Age == maxAge)
                {
                    Console.WriteLine(m.ToString());
                }
            }

            //3.Return a new list that contains Full Name = Last Name + First Name
            Console.WriteLine("\n3.Return a new list that contains Full Name = Last Name + First Name");

            foreach (Member m in memberList)
            {
                Console.WriteLine($"Full name of member: {m.FullName}");
            }

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
                            Console.WriteLine("List of members have birth year = 2000: ");

                            var query4 = from m in memberList
                                         where m.DateOfBirth.Year == 2000
                                         select m;
                            foreach (var m in query4)
                            {
                                Console.WriteLine(m.ToString());
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("List of members have birth year > 2000: ");

                            var query5 = from m in memberList
                                         where m.DateOfBirth.Year > 2000
                                         select m;
                            foreach (var m in query5)
                            {
                                Console.WriteLine(m.ToString());
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("List of members have birth year < 2000: ");

                            var query6 = from m in memberList
                                         where m.DateOfBirth.Year < 2000
                                         select m;
                            foreach (var m in query6)
                            {
                                Console.WriteLine(m.ToString());
                            }
                            break;
                        }
                }
            } while (option >= 1 && option <= 3);

            //5.Return the first person who was born in Ha Noi
            Console.WriteLine("\n5.Return the first person who was born in Ha Noi: ");

            var query7 = from m in memberList
                         where m.BirthPlace == "Ha Noi"
                         select m;

            foreach (var member in query7)
            {
                while( 0 <  query7.Count())
                {
                    Console.WriteLine(member.ToString());
                    break;
                }
                break;
            }        

           
            // while (0 < query7.Count())
            // {
            //     foreach (var member in query7)
            //     {
            //         Console.WriteLine(member.ToString());
            //         break;
            //     }
            //     break;
            // }

        }
    }
}