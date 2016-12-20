using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentFirstName;
            string studentLastName;
            DateTime studentBirthDate;

            GetStudentInformation(out studentFirstName, out studentLastName, out studentBirthDate);
            PrintStudentDetails(studentFirstName, studentLastName, studentBirthDate.ToString());
            //string studentAddressLine1;
            //string studentAddressLine2;
            //string studentCity;
            //string studentStateProvince;
            //string studentZipPostal;
            //string studentCountry;


            //// Assign sample student info
            //string studentFirstName = "John";
            //string studentLastName = "Student";
            //DateTime studentBirthDate = new DateTime(1995, 1, 31);
            //string studentAddressLine1 = "1 Main Street";
            //string studentAddressLine2 = string.Empty;
            //string studentCity = "Anytown";
            //string studentStateProvince = "MA";
            //string studentZipPostal = "01234";
            //string studentCountry = "United States";
/*
            // Write everything
            Console.WriteLine("Preset Values\n");
            Console.WriteLine("studentFirstName: {0}", studentFirstName);
            Console.WriteLine("studentLastName: {0}", studentLastName);
            Console.WriteLine("studentBirthDate: {0}", studentBirthDate);
            Console.WriteLine("studentAddressLine1: {0}", studentAddressLine1);
            Console.WriteLine("studentAddressLine2: {0}", studentAddressLine2);
            Console.WriteLine("studentCity: {0}", studentCity);
            Console.WriteLine("studentStateProvinc: {0}", studentStateProvince);
            Console.WriteLine("studentZipPostal: {0}", studentZipPostal);
            Console.WriteLine("studentCountry: {0}", studentCountry);

            Console.WriteLine("\nHit any key to continue on to input section.");
            Console.ReadKey();


            // Challenge: prompt user for student data, and save it to existing variables.
            Console.WriteLine("Enter a new value for each field.\n");

            Console.WriteLine("studentFirstName: {0}", studentFirstName);
            studentFirstName = Console.ReadLine();
            Console.WriteLine("New studentFirstName: {0}", studentFirstName);

            Console.WriteLine("studentLastName: {0}", studentLastName);
            studentLastName = Console.ReadLine();
            Console.WriteLine("New studentLastName: {0}", studentLastName);

            bool invalidData = true;
            while (invalidData)
            {
                try
                {
                    Console.WriteLine("studentBirthDate: {0}", studentBirthDate);
                    Console.Write("Use MM/DD/YYYY\n");
                    studentBirthDate = DateTime.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                Console.WriteLine("studentBirthDate: {0}", studentBirthDate);
                invalidData = false;
            }

            Console.WriteLine("studentAddressLine1: {0}\n", studentAddressLine1);
            studentAddressLine1 = Console.ReadLine();
            Console.WriteLine("New studentAddressLine1: {0}\n", studentAddressLine1);

            Console.WriteLine("studentAddressLine2: {0}\n", studentAddressLine2);
            studentAddressLine2 = Console.ReadLine();
            Console.WriteLine("New studentAddressLine2: {0}\n", studentAddressLine2);

            Console.WriteLine("studentCity: {0}\n", studentCity);
            studentCity = Console.ReadLine();
            Console.WriteLine("New studentCity: {0}\n", studentCity);

            Console.WriteLine("studentStateProvince: {0}\n", studentStateProvince);
            studentStateProvince = Console.ReadLine();
            Console.WriteLine("New studentStateProvince: {0}\n", studentStateProvince);

            Console.WriteLine("studentZipPostal: {0}\n", studentZipPostal);
            studentZipPostal = Console.ReadLine();
            Console.WriteLine("New studentZipPostal: {0}\n", studentZipPostal);

            Console.WriteLine("studentCountry: {0}\n", studentCountry);
            studentCountry = Console.ReadLine();
            Console.WriteLine("New studentCountry: {0}\n", studentCountry);


            // Write everything - definitely NOT DRY code right now
            Console.WriteLine("New Values\n");
            Console.WriteLine("studentFirstName: {0}", studentFirstName);
            Console.WriteLine("studentLastName: {0}", studentLastName);
            Console.WriteLine("studentBirthDate: {0}", studentBirthDate);
            Console.WriteLine("studentAddressLine1: {0}", studentAddressLine1);
            Console.WriteLine("studentAddressLine2: {0}", studentAddressLine2);
            Console.WriteLine("studentCity: {0}", studentCity);
            Console.WriteLine("studentStateProvinc: {0}", studentStateProvince);
            Console.WriteLine("studentZipPostal: {0}", studentZipPostal);
            Console.WriteLine("studentCountry: {0}", studentCountry);
*/
            Console.WriteLine("\nHit any key to terminate the program.");
            Console.ReadKey();
        }

        static void GetStringData(string prompt, out string data, bool required = true)
        {
            do
            {
                Console.WriteLine(prompt);
                data = Console.ReadLine();
            } while ((string.IsNullOrEmpty(data)) && required);
        }

        static void GetStudentInformation(out string firstName, out string lastName, out DateTime birthDate)
        {
            GetStringData("Enter the student's first name (REQUIRED): ", out firstName);
            GetStringData("Enter the student's last name (REQUIRED): ", out lastName);
            GetDate("")
            bool invalidData = true;
            birthDate = DateTime.Now;
            while (invalidData)
            {
                try
                {
                    Console.WriteLine("Enter the student's birth date. Use MM/DD/YYYY (REQUIRED): ");
                    birthDate = DateTime.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                Console.WriteLine("student birth date: {0}", birthDate);
                invalidData = false;
            }


            //This is to be added back in later.
            //bool invalidData = true;
            //birthDate = DateTime.Now;
            //while (invalidData)
            //{
            //    try
            //    {
            //        Console.WriteLine("Enter the student's birth date. Use MM/DD/YYYY (REQUIRED): ");
            //        birthDate = DateTime.Parse(Console.ReadLine());
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //        continue;
            //    }
            //    Console.WriteLine("student birth date: {0}", birthDate);
            //    invalidData = false;
            //}
        }

        static void PrintStudentDetails(string first, string last, string birthDate)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthDate);
        }

    }
}
