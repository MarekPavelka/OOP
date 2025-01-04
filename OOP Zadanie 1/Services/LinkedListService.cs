using OOP_Zadanie_1.Models;

namespace OOP_Zadanie_1.Services
{
    public class LinkedListService
    {
        private Node? head;
        private ConsoleService _consoleService;

        public LinkedListService(ConsoleService consoleService)
        {
            _consoleService = consoleService;
        }

        public void AddOrUpdateStudent(Student student)
        {
            var isListEmpty = head == null;
            if (isListEmpty)
            {
                var newNode = new Node { Student = student };
                head = newNode;
                _consoleService.DisplayAddedMsg(student);

                return;
            }

            var currentNode = head;
            while (true)
            {
                var hasCurrentNodeSameStudentId = currentNode.Student.Number == student.Number;
                if (hasCurrentNodeSameStudentId)
                {
                    UpdateStudent(currentNode, student);
                    _consoleService.DisplayUpdatedMsg(student);

                    return;
                }

                if (IsLastNode(currentNode))
                {
                    var newNode = new Node { Student = student };
                    currentNode.Next = newNode;
                    _consoleService.DisplayAddedMsg(student);

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

        public void DeleteStudent(int studentNumber)
        {
            var shouldDeleteHeadNode = head?.Student.Number == studentNumber;
            if (shouldDeleteHeadNode)
            {
                head = head?.Next;
                _consoleService.DisplayDeletedMsg(studentNumber);

                return;
            }

            Func<Node, bool> predicate = node => node.Next != null && node.Next.Student.Number == studentNumber;
            Action<Node> action = BypassNodeToDelete;

            SearchStudentInList(predicate, out var _, BypassNodeToDelete);
            _consoleService.DisplayDeletedMsg(studentNumber);
        }

        public void DisplayAllStudents()
        {
            if (head == null)
            {
                _consoleService.DisplayEmptyListMsg();
                return;
            }

            var currentNode = head;

            while (true)
            {
                if (IsEndOfList(currentNode))
                {
                    break;
                }

                _consoleService.DisplaySingleStudent(currentNode.Student, drawSeparationLines: false);
                currentNode = currentNode.Next;
            }

            Console.WriteLine($"------------------------------------------\n");
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
