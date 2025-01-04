using OOP_Zadanie_1.Models;

namespace OOP_Zadanie_1.Services
{
    public class LinkedListService
    {
        private Node? head;

        public void AddOrUpdateStudent(Student student)
        {
            var isListEmpty = head == null;
            if (isListEmpty)
            {
                var newNode = new Node { Student = student };
                head = newNode;
                Console.WriteLine($"Added new student with number: '{student.StudentNumber}'");
                return;
            }

            var currentNode = head;
            while (true)
            {
                var hasCurrentNodeSameStudentId = currentNode.Student.StudentNumber == student.StudentNumber;
                if (hasCurrentNodeSameStudentId)
                {
                    UpdateStudent(currentNode, student);
                    Console.WriteLine($"Updated existing student with number: '{student.StudentNumber}'");
                    return;
                }

                if (IsLastNode(currentNode))
                {
                    var newNode = new Node { Student = student };
                    currentNode.Next = newNode;
                    Console.WriteLine($"Added new student: '{student.Name} {student.Surname}' with number: '{student.StudentNumber}'");
                    break;
                }

                currentNode = currentNode.Next;
            }
        }

        public bool TrySearchStudentBySurname(string surname, out Student? student)
        {
            student = null;

            if (head == null)
            {
                return false;
            }

            surname.Trim();
            var currentNode = head;
            while (true)
            {
                var isEndOfList = currentNode == null;
                if (isEndOfList)
                {
                    return false;
                }

                var hasCurrentNodeSameSurname = currentNode.Student.Surname == surname;
                if (hasCurrentNodeSameSurname)
                {
                    student = currentNode.Student;
                    return true;
                }

                currentNode = currentNode.Next;
            }
        }

        public void DisplayAllStudents()
        {
            if (head == null)
            {
                Console.WriteLine("No students in the list.");
                return;
            }

            Console.WriteLine("Students:");
            var currentNode = head;
            while (true)
            {
                var isEndOfList = currentNode == null;
                if (isEndOfList)
                {
                    break;
                }

                Console.WriteLine($"Name: {currentNode.Student.Name}, Surname: {currentNode.Student.Surname}, Number: {currentNode.Student.StudentNumber}");
                currentNode = currentNode.Next;
            }
        }

        public void DisplaySingleStudent(Student student)
        {
            Console.WriteLine($"Name: {student.Name}, Surname: {student.Surname}, Number: {student.StudentNumber}");
        }

        private void UpdateStudent(Node currentNode, Student newStudent)
        {
            currentNode.Student.Name = newStudent.Name;
            currentNode.Student.Surname = newStudent.Surname;
        }

        private bool IsLastNode(Node currentNode)
        {
            return currentNode.Next == null;
        }
    }
}
