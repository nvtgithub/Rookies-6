using System;
using System.Collections.Generic;

namespace Assignment
{
    class Progaram
    {
        public static void Main(String[] args)
        {
            var memberList = new List<Member>();

            memberList.Add(new Member("Tien", "Nguyen", "Male", new DateTime(2001, 2, 23), "0147258369", "Ha Noi", false));
            memberList.Add(new Member("Anh", "Nguyen", "Female", new DateTime(2000, 2, 23), "0147258369", "Ha Noi", true));
            memberList.Add(new Member("Tung", "Nguyen", "Male", new DateTime(1999, 2, 23), "0147258369", "Hai Duong", false));

            //1.Return a list of members who is Male
            var maleMember = new List<Member>();
            foreach (Member m in memberList)
            {
                if (m.Gendar == "Male")
                {
                    maleMember.Add(m);
                }
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("1.Return a list of members who is Male: ");
            foreach (Member m in maleMember)
            {
                Console.WriteLine(m.ToString());
            }

            //2.Return the oldest on base "Age"
            Console.WriteLine("----------------------------------");
            Console.WriteLine("2.Return the oldest on base 'Age': ");

            uint oldestMember = 0;

            foreach (Member m in memberList)
            {
                if (m.Age > oldestMember)
                {
                    oldestMember = m.Age;
                }
            }

            foreach (Member m in memberList)
            {
                if (m.Age == oldestMember)
                {
                    Console.WriteLine(m.ToString());
                    break;
                }
            }

            //3.Return a new list that contains Full Name = Last Name + First Name
            Console.WriteLine("----------------------------------");
            Console.WriteLine("3.Return a new list that contains Full Name = Last Name + First Name: ");
            foreach (Member m in memberList)
            {
                Console.WriteLine($"Full name of member: {m.FullName}");
            }

            //4.Return 3 list of members who has birth year is 2000 or greaterthan 2000 or lessthan 2000
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Return 3 list of members who has birth year is 2000 or greaterthan 2000 or lessthan 2000: ");
            int option = 0;
            do
            {
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("List of members have birth year = 2000: ");
                            foreach (Member m in memberList)
                            {
                                if (m.DateOfBirth.Year == 2000)
                                    Console.WriteLine(m.ToString());
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("List of members have birth year > 2000: ");
                            foreach (Member m in memberList)
                            {
                                if (m.DateOfBirth.Year > 2000)
                                    Console.WriteLine(m.ToString());
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("List of members have birth year < 2000: ");
                            foreach (Member m in memberList)
                            {
                                if (m.DateOfBirth.Year < 2000)
                                    Console.WriteLine(m.ToString());
                            }
                            break;
                        }
                }
            } while (option >= 1 && option <= 3);

            //5.Return the first person who was born in Ha Noi
            Console.WriteLine("----------------------------------");
            Console.WriteLine("5.Return the first person who was born in Ha Noi: ");
            
            int i = 0;
            
            while (i < memberList.Count)
            {
                var m = memberList[i];
                if (m.BirthPlace == "Ha Noi")
                {
                    Console.WriteLine(m.ToString());
                    break;
                }
                else i++;
            }
        }
    }
}