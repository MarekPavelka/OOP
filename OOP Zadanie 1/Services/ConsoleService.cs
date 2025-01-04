using OOP_Zadanie_1.Models;

namespace OOP_Zadanie_1.Services
{
    public class ConsoleService
    {
        public void DisplayMenu()
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("*              MENU OPTIONS              *");
            Console.WriteLine("******************************************");
            Console.WriteLine("*  1. Add new student                    *");
            Console.WriteLine("*  2. Search student by surname          *");
            Console.WriteLine("*  3. Search student by number           *");
            Console.WriteLine("*  4. Display all students               *");
            Console.WriteLine("*  5. Delete student by number           *");
            Console.WriteLine("*  0. Exit                               *");
            Console.WriteLine("******************************************");
        }

        public void DisplaySingleStudent(Student student, bool drawSeparationLines = true)
        {
            if (drawSeparationLines)
            {
                Console.WriteLine($"------------------------------------------");
            }

            Console.WriteLine($"Student:");
            Console.WriteLine($"        FirstName: '{student.FirstName}'");
            Console.WriteLine($"        Surname: '{student.Surname}'");
            Console.WriteLine($"        Number: '{student.Number}");

            if (drawSeparationLines)
            {
                Console.WriteLine($"------------------------------------------\n");
            }
        }

        public void DisplayEmptyListMsg()
        {
            Console.WriteLine($"------------------------------------------");
            Console.WriteLine("Students list is empty.");
            Console.WriteLine($"------------------------------------------\n");
        }

        public void DisplayAddedMsg(Student student)
        {
            Console.WriteLine($"------------------------------------------");
            Console.WriteLine($"Successfully added new student '{student.FirstName} {student.Surname}'");
            Console.WriteLine($"------------------------------------------\n");
        }

        public void DisplayUpdatedMsg(Student student)
        {
            Console.WriteLine($"------------------------------------------");
            Console.WriteLine($"Successfully updated existing student with number '{student.Number}'");
            Console.WriteLine($"------------------------------------------\n");
        }

        public void DisplayDeletedMsg(int studentNumber)
        {
            Console.WriteLine($"------------------------------------------");
            Console.WriteLine($"Successfully deleted student with number '{studentNumber}'");
            Console.WriteLine($"------------------------------------------\n");
        }

        public void DisplayNotFoundMsg(string studentName)
        {
            Console.WriteLine($"------------------------------------------");
            Console.WriteLine($"Failed to find student with surname '{studentName}'");
            Console.WriteLine($"------------------------------------------\n");
        }

        public void DisplayNotFoundMsg(int studentId)
        {
            Console.WriteLine($"------------------------------------------");
            Console.WriteLine($"Failed to find student with number '{studentId}'");
            Console.WriteLine($"------------------------------------------\n");
        }

        public string GetValidString(string consoleMsg, bool drawSeparationLine = false)
        {
            Console.Write(consoleMsg);
            var consoleInput = Console.ReadLine();

            if (drawSeparationLine)
            {
                Console.WriteLine($"------------------------------------------");
            }
            if (consoleInput == null)
            {
                return string.Empty;
            }

            return consoleInput.Trim();
        }

        public int GetValidInteger(string consoleMsg = null, bool drawSeparationLine = false)
        {
            while (true)
            {
                if (consoleMsg != null)
                {
                    Console.Write(consoleMsg);
                }

                var consoleInput = Console.ReadLine();

                if (drawSeparationLine)
                {
                    Console.WriteLine($"------------------------------------------");
                }
                if (int.TryParse(consoleInput, out var validInteger))
                {
                    return validInteger;
                }

                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
