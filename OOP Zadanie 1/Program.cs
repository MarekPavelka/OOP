using OOP_Zadanie_1.Models;
using OOP_Zadanie_1.Services;

var consoleService = new ConsoleService();
var linkedStudentsService = new LinkedListService(consoleService);

while (true)
{
    consoleService.DisplayMenu();
    var userInput = consoleService.GetValidInteger(drawSeparationLine: true);

    switch (userInput)
    {
        case 1:
            {
                var studentFirstName = consoleService.GetValidString("Enter student first name: ");
                var studentSurname = consoleService.GetValidString("Enter student surname: ");
                var studentNumber = consoleService.GetValidInteger("Enter student number: ");

                Student newStudent = new Student
                {
                    FirstName = studentFirstName,
                    Surname = studentSurname,
                    Number = studentNumber
                };

                linkedStudentsService.AddOrUpdateStudent(newStudent);

                break;
            }
        case 2:
            {
                var studentSurname = consoleService.GetValidString("Search student by his surname: ");
                var wasStudentFound = linkedStudentsService.TrySearchStudentBySurname(studentSurname, out var student);
                if (!wasStudentFound)
                {
                    consoleService.DisplayNotFoundMsg(studentSurname);
                }
                else
                {
                    consoleService.DisplaySingleStudent(student);
                }

                break;
            }
        case 3:
            {                
                var studentNumber = consoleService.GetValidInteger("Search student by his number: ");
                var wasStudentFound = linkedStudentsService.TrySearchStudentByNumber(studentNumber, out var student);
                if (!wasStudentFound)
                {
                    consoleService.DisplayNotFoundMsg(studentNumber);
                }
                else
                {
                    consoleService.DisplaySingleStudent(student);
                }

                break;
            }
        case 4:
            {
                linkedStudentsService.DisplayAllStudents();
                break;
            }
        case 5:
            {
                var studentNumber = consoleService.GetValidInteger("Delete student by his number: ");
                var wasStudentFound = linkedStudentsService.TrySearchStudentByNumber(studentNumber, out var student);
                if (!wasStudentFound)
                {
                    consoleService.DisplayNotFoundMsg(studentNumber);
                }
                else
                {
                    linkedStudentsService.DeleteStudent(studentNumber);
                }
                
                break;
            }
        case 0:
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
