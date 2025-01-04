using OOP_Zadanie_1.Models;
using OOP_Zadanie_1.Services;

LinkedListService linkedStudents = new LinkedListService();

while (true)
{
    Console.WriteLine("\nEnter 1 to add/update a student, 2 to display students, 0 to exit:");
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

                linkedStudents.AddOrUpdateStudent(newStudent);
                break;
            }

        case "2":
            {
                Console.WriteLine("Search by surname is not implemented");
                break;
            }
        case "3":
            {
                Console.WriteLine("Search by number is not implemented");
                break;
            }
        case "4":
            {
                linkedStudents.DisplayAllStudents();
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
