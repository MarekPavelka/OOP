using OOP_Zadanie_1.Models;
using OOP_Zadanie_1.Services;

var linkedStudentsService = new LinkedListService();
var inputService = new ConsoleInputService();

while (true)
{
    Console.WriteLine("\nEnter 1 add/update a student, 2 search student by his surname, 3 search student by his number, 4 display all students, 0 exit");
    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            {
                var studentFirstName = inputService.GetValidString("Enter student first name: ");
                var studentSurname = inputService.GetValidString("Enter student surname: ");
                var studentNumber = inputService.GetValidInteger("Enter student number: ");

                Student newStudent = new Student
                {
                    FirstName = studentFirstName,
                    Surname = studentSurname,
                    Number = studentNumber
                };

                linkedStudentsService.AddOrUpdateStudent(newStudent);

                break;
            }
        case "2":
            {
                var studentSurname = inputService.GetValidString("Search student by his surname: ");
                var wasStudentFound = linkedStudentsService.TrySearchStudentBySurname(studentSurname, out var student);
                if (!wasStudentFound)
                {
                    Console.WriteLine($"Student with surname: '{studentSurname}' was not found.");
                }
                else
                {
                    linkedStudentsService.DisplaySingleStudent(student);
                }

                break;
            }
        case "3":
            {
                var studentNumber = inputService.GetValidInteger("Search student by his number: ");
                var wasStudentFound = linkedStudentsService.TrySearchStudentByNumber(studentNumber, out var student);
                if (!wasStudentFound)
                {
                    Console.WriteLine($"Student with number: '{studentNumber}' was not found.");
                }
                else
                {
                    linkedStudentsService.DisplaySingleStudent(student);
                }

                break;
            }
        case "4":
            {
                linkedStudentsService.DisplayAllStudents();
                break;
            }
        case "5":
            {
                Console.WriteLine("Delete by number is not implemented");
                break;
            }

        case "0":
            {
                break;
            }

        default:
            {
                Console.WriteLine("Invalid input. Please try again...");
                break;
            }
    }
}
