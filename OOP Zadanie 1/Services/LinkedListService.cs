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
                var newNode = new Node { Summary = student };
                head = newNode;
                Console.WriteLine($"Added new student with number: '{student.StudentNumber}'");
                return;
            }

            var currentNode = head;
            while (true)
            {
                var hasCurrentNodeSameStudentId = currentNode.Summary.StudentNumber == student.StudentNumber;
                if (hasCurrentNodeSameStudentId)
                {
                    UpdateStudent(currentNode, student);
                    Console.WriteLine($"Updated existing student with number: '{student.StudentNumber}'");
                    return;
                }

                if (IsLastNode(currentNode))
                {
                    var newNode = new Node { Summary = student };
                    currentNode.Next = newNode;
                    Console.WriteLine($"Added new student: '{student.Name} {student.Surname}' with number: '{student.StudentNumber}'");
                    break;
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

                Console.WriteLine($"Name: {currentNode.Summary.Name}, Surname: {currentNode.Summary.Surname}, Number: {currentNode.Summary.StudentNumber}");
                currentNode = currentNode.Next;
            }
        }

        private void UpdateStudent(Node currentNode, Student newStudent)
        {
            currentNode.Summary.Name = newStudent.Name;
            currentNode.Summary.Surname = newStudent.Surname;
        }

        private bool IsLastNode(Node currentNode)
        {
            return currentNode.Next == null;
        }
    }
}
