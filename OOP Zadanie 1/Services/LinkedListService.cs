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
                Console.WriteLine($"Added new student with number: '{student.Number}'");
                return;
            }

            var currentNode = head;
            while (true)
            {
                var hasCurrentNodeSameStudentId = currentNode.Student.Number == student.Number;
                if (hasCurrentNodeSameStudentId)
                {
                    UpdateStudent(currentNode, student);
                    Console.WriteLine($"Updated existing student with number: '{student.Number}'");
                    return;
                }

                if (IsLastNode(currentNode))
                {
                    var newNode = new Node { Student = student };
                    currentNode.Next = newNode;
                    Console.WriteLine($"Added new student: '{student.FirstName} {student.Surname}' with number: '{student.Number}'");
                    break;
                }

                currentNode = currentNode.Next;
            }
        }

        public bool TrySearchStudentBySurname(string studentSurname, out Student? student)
        {
            student = null;

            if (head == null)
            {
                return false;
            }
            
            var currentNode = head;
            while (true)
            {
                var isEndOfList = currentNode == null;
                if (isEndOfList)
                {
                    return false;
                }

                var hasCurrentNodeSameSurname = currentNode.Student.Surname == studentSurname;
                if (hasCurrentNodeSameSurname)
                {
                    student = currentNode.Student;
                    return true;
                }

                currentNode = currentNode.Next;
            }
        }

        public bool TrySearchStudentByNumber(int studentNumber, out Student? student)
        {
            student = null;

            if (head == null)
            {
                return false;
            }

            var currentNode = head;
            while (true)
            {
                var isEndOfList = currentNode == null;
                if (isEndOfList)
                {
                    return false;
                }

                var hasCurrentNodeSameSurname = currentNode.Student.Number == studentNumber;
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

                Console.WriteLine($"Name: {currentNode.Student.FirstName}, Surname: {currentNode.Student.Surname}, Number: {currentNode.Student.Number}");
                currentNode = currentNode.Next;
            }
        }

        public void DisplaySingleStudent(Student student)
        {
            Console.WriteLine($"Name: {student.FirstName}, Surname: {student.Surname}, Number: {student.Number}");
        }

        private void UpdateStudent(Node currentNode, Student newStudent)
        {
            currentNode.Student.FirstName = newStudent.FirstName;
            currentNode.Student.Surname = newStudent.Surname;
        }

        private bool IsLastNode(Node currentNode)
        {
            return currentNode.Next == null;
        }
    }
}
