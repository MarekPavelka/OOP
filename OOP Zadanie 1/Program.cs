using OOP_Zadanie_1.Models;
using OOP_Zadanie_1.Services;

LinkedListService linkedStudentsService = new LinkedListService();

while (true)
{
    Console.WriteLine("\nEnter 1 add/update a student, 2 search student by his surname, 4 display all students, 0 exit");
    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            {
                Console.Write("Enter student name: ");
                var name = Console.ReadLine();

                Console.Write("Enter student surname: ");
                var surname = Console.ReadLine();

                Console.Write("Enter student number: ");
                var studentNumber = Console.ReadLine();

                Student newStudent = new Student
                {
                    Name = name,
                    Surname = surname,
                    StudentNumber = studentNumber
                };

                linkedStudentsService.AddOrUpdateStudent(newStudent);
                break;
            }

        case "2":
            {
                Console.Write("Search student by surname: ");
                var surname = Console.ReadLine();
                var wasStudentFound = linkedStudentsService.TrySearchStudentBySurname(surname, out var student);
                if (!wasStudentFound)
                {
                    Console.WriteLine($"Student with surname: '{surname}' was not found.");
                }
                else
                {
                    linkedStudentsService.DisplaySingleStudent(student);
                }

                break;
            }
        case "3":
            {
                Console.WriteLine("Search by number is not implemented");
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
