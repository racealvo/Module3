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
            StudentInfo();
            TeacherInfo();
            UProgramInfo();
            DegreeInformation();
            CourseInformation();

            Console.WriteLine("\nHit any key to terminate the program.");
            Console.ReadKey();
        }

        static void StudentInfo()
        {
            // Student Info
            string studentFirstName;
            string studentLastName;
            //DateTime studentBirthDate;  dumb down the birthdate for the exercise
            string studentBirthDate;

            GetBio("student", out studentFirstName, out studentLastName, out studentBirthDate);
            PrintBio("Student", studentFirstName, studentLastName, studentBirthDate.ToString());
        }

        static void TeacherInfo()
        {
            // Teacher Info
            string teacherFirstName;
            string teacherLastName;
            //DateTime teacherBirthDate;  dumb down the birthdate for the exercise
            string teacherBirthDate;

            GetBio("teacher", out teacherFirstName, out teacherLastName, out teacherBirthDate);
            PrintBio("Teacher", teacherFirstName, teacherLastName, teacherBirthDate.ToString());
        }

        static void UProgramInfo()
        {
            string programName;
            string departmentHead;
            string degrees;

            GetStringData("Enter program name:", out programName);
            GetStringData("Enter department head:", out departmentHead);
            GetStringData("Enter degrees (separate with commas):", out degrees);

            PrintUProgram(programName, departmentHead, degrees);
        }

        static void PrintUProgram(string programName, string departmentHead, string degrees)
        {
            Console.WriteLine("Program {0} is headed by {1}, and offers these degrees: {2}.", programName, departmentHead, degrees);
            Console.WriteLine("\n\n");
        }

        static void DegreeInformation()
        {
            string degreeName;
            int creditsRequired;

            GetStringData("Enter degree name:", out degreeName);

            bool invalidData = true;
            while (invalidData)
            {
                try
                {
                    Console.WriteLine("Enter the number of credits required to complete the degree: ");
                    creditsRequired = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                invalidData = false;
            }
        }

        static void GetCourseInformation()
        {

        }

        static void GetStringData(string prompt, out string data, bool required = true)
        {
            do
            {
                Console.WriteLine(prompt);
                data = Console.ReadLine();
            } while ((string.IsNullOrEmpty(data)) && required);
        }

        static void GetBio(string bioType, out string firstName, out string lastName, out string birthDate)
        {
            GetStringData("Enter the " + bioType + "'s first name (REQUIRED): ", out firstName);
            GetStringData("Enter the " + bioType + "'s last name (REQUIRED): ", out lastName);
            GetStringData("Enter the " + bioType + "'s birth date (REQUIRED): ", out birthDate);

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

        static void PrintBio(string bioType, string first, string last, string birthDate)
        {
            Console.WriteLine("{0}: {1} {2} was born on: {3}", bioType, first, last, birthDate);
            Console.WriteLine("\n\n");
        }

    }
}
