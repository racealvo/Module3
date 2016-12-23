using System;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student Info
            string studentFirstName;
            string studentLastName;
            //DateTime studentBirthDate;  dumb down the birthdate for the exercise
            string studentBirthDate;

            // Teacher Info
            string teacherFirstName;
            string teacherLastName;
            //DateTime teacherBirthDate;  dumb down the birthdate for the exercise
            string teacherBirthDate;

            // University Program Info
            string programName;
            string departmentHead;
            string degrees;

            // Degree Info
            string degreeName;
            int creditsRequired;

            // Course Info
            string courseName;
            int credits;
            int duration;
            string teacher;


            try
            {
                StudentInfo(out studentFirstName, out studentLastName, out studentBirthDate);
                TeacherInfo(out teacherFirstName, out teacherLastName, out teacherBirthDate);
                UProgramInfo(out programName, out departmentHead, out degrees);
                DegreeInformation(out degreeName, out creditsRequired);
                CourseInformation(out courseName, out credits, out duration, out teacher);

                ValidateDate(studentBirthDate);
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Oops.  Please pardon our appearance.  This feature has not yet been implemented: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\nHit any key to terminate the program.");
            Console.ReadKey();
        }

        static void StudentInfo(out string studentFirstName, out string studentLastName, out string studentBirthDate)
        {
            GetBio("student", out studentFirstName, out studentLastName, out studentBirthDate);
            PrintBio("Student", studentFirstName, studentLastName, studentBirthDate.ToString());
        }

        static void TeacherInfo(out string teacherFirstName, out string teacherLastName, out string teacherBirthDate)
        {
            GetBio("teacher", out teacherFirstName, out teacherLastName, out teacherBirthDate);
            PrintBio("Teacher", teacherFirstName, teacherLastName, teacherBirthDate.ToString());
        }

        /// <summary>
        /// Get biographic information (student or teacher) - name, birthdate, address
        /// </summary>
        /// <param name="bioType"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthDate"></param>
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

        /// <summary>
        /// Print biographic information (student or teacher)
        /// </summary>
        /// <param name="bioType"></param>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <param name="birthDate"></param>
        static void PrintBio(string bioType, string first, string last, string birthDate)
        {
            Console.WriteLine("{0}: {1} {2} was born on: {3}", bioType, first, last, birthDate);
            Console.WriteLine("\n\n");
        }

        static void ValidateDate(string date)
        {
            throw new NotImplementedException("ValidateDate");
        }

        /// <summary>
        /// Collect university program information
        /// </summary>
        /// <param name="programName"></param>
        /// <param name="departmentHead"></param>
        /// <param name="degrees"></param>
        static void UProgramInfo(out string programName, out string departmentHead, out string degrees)
        {
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

        /// <summary>
        /// Collect degree info.
        /// </summary>
        static void DegreeInformation(out string degreeName, out int creditsRequired)
        {
            GetStringData("Enter degree name:", out degreeName);
            GetWholeNumberData("Enter the number of credits required to complete the degree:", out creditsRequired);

            PrintDegreeInformation(degreeName, creditsRequired);
        }

        static void PrintDegreeInformation(string degreeName, int creditsRequired)
        {
            Console.WriteLine("{0} degree requires {1} credits for completion.", degreeName, creditsRequired);
            Console.WriteLine("\n\n");
        }

        /// <summary>
        /// Collect course info.
        /// </summary>
        static void CourseInformation(out string courseName, out int credits, out int duration, out string teacher)
        {
            GetStringData("Enter course name:", out courseName);
            GetWholeNumberData("Enter the number of credits " + courseName + " is worth:", out credits);
            GetWholeNumberData("Enter the duration of the course in weeks:", out duration);
            GetStringData("Enter the teacher's name:", out teacher);
            //Todo: validate teacher from list of teachers.

            PrintCourseInformation(courseName, credits, duration, teacher);
        }

        static void PrintCourseInformation(string courseName, int credits, int duration, string teacher)
        {
            Console.WriteLine("The course {0} earns the student {1} credits.  It lasts {2} weeks and is taught by {3}.", courseName, credits.ToString(), duration.ToString(), teacher);
            Console.WriteLine("\n\n");
        }

        /// <summary>
        /// Get string data from the user.  If the data is required, keep looping until we get something legitimate.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="data"></param>
        /// <param name="required"></param>
        static void GetStringData(string prompt, out string data, bool required = true)
        {
            do
            {
                Console.WriteLine(prompt);
                data = Console.ReadLine();
            } while (required && (string.IsNullOrWhiteSpace(data)));
        }

        /// <summary>
        /// Get a whole number.  
        /// Validate the input
        ///   * is a whole number
        ///   * positive
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="wholeNumber"></param>
        static void GetWholeNumberData(string prompt, out int wholeNumber)
        {
            wholeNumber = -1;
            bool invalidData = true;

            while (invalidData)
            {
                try
                {
                    Console.WriteLine(prompt);
                    wholeNumber = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Your input was invalid.  Please enter a whole number.");
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                // no negatives allowed
                if (wholeNumber < 0)
                {
                    Console.WriteLine("Input must be greater than zero.");
                    continue;
                }

                invalidData = false;
            }
        }
    }
}
