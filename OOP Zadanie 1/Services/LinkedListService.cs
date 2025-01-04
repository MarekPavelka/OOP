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
                Console.WriteLine($"Added new student with number '{student.Number}'");
                return;
            }

            var currentNode = head;
            while (true)
            {
                var hasCurrentNodeSameStudentId = currentNode.Student.Number == student.Number;
                if (hasCurrentNodeSameStudentId)
                {
                    UpdateStudent(currentNode, student);
                    Console.WriteLine($"Updated existing student with number '{student.Number}'");
                    return;
                }

                if (IsLastNode(currentNode))
                {
                    var newNode = new Node { Student = student };
                    currentNode.Next = newNode;
                    Console.WriteLine($"Added new student '{student.FirstName} {student.Surname}' with number '{student.Number}'");
                    break;
                }

                currentNode = currentNode.Next;
            }
        }

        public bool TrySearchStudentBySurname(string studentSurname, out Student? student)
        {
            Func<Node, bool> predicate = node => node.Student.Surname == studentSurname;
            return SearchStudentInList(predicate, out student);
        }

        public bool TrySearchStudentByNumber(int studentNumber, out Student? student)
        {
            Func<Node, bool> predicate = node => node.Student.Number == studentNumber;
            return SearchStudentInList(predicate, out student);
        }

        public bool DeleteStudent(int studentNumber)
        {
            if (head == null)
            {
                return false;
            }

            var shouldDeleteHeadNode = head.Student.Number == studentNumber;
            if (shouldDeleteHeadNode)
            {
                head = head.Next;
                return true;
            }

            Func<Node, bool> predicate = node => node.Next != null && node.Next.Student.Number == studentNumber;
            Action<Node> action = BypassNodeToDelete;

            return SearchStudentInList(predicate, out var _, BypassNodeToDelete);
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
                if (IsEndOfList(currentNode))
                {
                    break;
                }

                DisplaySingleStudent(currentNode.Student);
                currentNode = currentNode.Next;
            }
        }

        public void DisplaySingleStudent(Student student)
        {
            Console.WriteLine($"Name: {student.FirstName}, Surname: {student.Surname}, Number: {student.Number}");
        }

        #region private
        private bool SearchStudentInList(Func<Node, bool> predicate, out Student? student, Action<Node>? action = null)
        {
            student = null;

            if (head == null)
            {
                return false;
            }

            var currentNode = head;

            while (!IsEndOfList(currentNode))
            {
                if (predicate(currentNode))
                {
                    student = currentNode.Student;
                    action?.Invoke(currentNode);
                    return true;
                }

                currentNode = currentNode.Next;
            }

            return false;
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

        private bool IsEndOfList(Node currentNode)
        {
            return currentNode == null;
        }

        private void BypassNodeToDelete(Node currentNode)
        {
            currentNode.Next = currentNode.Next.Next;
        }
        #endregion
    }
}
