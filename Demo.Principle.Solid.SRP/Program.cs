using Demo.Principle.Solid.SRP.Entities;
using Demo.Principle.Solid.SRP.Services;
using System;
using System.Linq;

namespace Demo.Principle.Solid.SRP
{
    class Program
    {
        private static StudentService _studentService = new StudentService();
        private static NoteService _noteService = new NoteService();
        private static string op = default(string);

        static void Main(string[] args)
        {
            ShowOptions();

            Console.ReadKey();
        }

        private static void ShowOptions()
        {
            do
            {
                Console.Write("\n******* Sistema de Notas ********\n" +
                    "\n1- Cadastrar Aluno:" +
                    "\n2- Listar Aluno:" +
                    "\n3- Cadastrar Notas:" +
                    "\n4- Mostrar Média por Aluno:" +
                    "\n5- Sair" +
                    "\nEscolha uma opção: ");

                op = Console.ReadLine();

                ChooseOption(op);
            } 
            while (op != "5");
        }

        private static void ChooseOption(string op)
        {
            switch (op)
            {
                case "1":
                    RegisterStudents();
                    break;
                case "2":
                    ShowStudents();
                    break;
                case "3":
                    RegisterNote();
                    break;
                case "4":
                    ShowMediaNotas();
                    break;
                case "5":
                    CloseSession();
                    break;
                default:
                    InvalidOption();
                    break;
            }
        }

        private static void RegisterStudents()
        {

            Console.Write("\n----- Cadastro de Alunos -----\nMatricula do Aluno: ");
            int studentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nome do Aluno: ");
            string studentName = Console.ReadLine();

            _studentService.AddStudent(studentId, studentName);

            ShowOptions();
        }

        private static void ShowStudents()
        {
            var students = _studentService.GetStudents();

            if (students != null && students.Any())
            {
                Console.WriteLine("\n----- Lista de alunos cadastrados -----");

                foreach (var student in students)
                    Console.WriteLine($"Matricula: {student.Id}, Nome: {student.Name}");
            }
            else
                Console.WriteLine("\nNão existem alunos cadastrados!\n");

            ShowOptions();
        }

        private static void RegisterNote()
        {
            Console.Write("\n----- Cadastro de Notas -----\nInforme a matricula do aluno: ");
            int studentId = Convert.ToInt32(Console.ReadLine());

            var student = _studentService.GetStudentById(studentId);

            if (student == null)
            {
                Console.WriteLine("\nAluno não cadastrado.\n");
                return;
            }

            var notes = _noteService.VerifyIfNotesRegister(studentId);

            if (notes)
            {
                Console.WriteLine("\nAluno possui notas cadastradas.\n");
                return;
            }

            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"Informe a {i}° nota: ");
                decimal value = Convert.ToDecimal(Console.ReadLine());

                _noteService.AddNote(student.Id, value);
            }

            Console.WriteLine("\nCadastro de notas realizado.\n");
        }

        private static void ShowMediaNotas()
        {
            Console.Write("\n----- Média de Notas -----\n");

            var students = _studentService.GetStudents();

            if (students == null || !students.Any())
                Console.WriteLine("Não existem alunos cadastrados!");
            else
            {
                foreach (var student in students)
                {
                    var notes = _noteService.GetNoteByStudent(student.Id);
                    var media = default(decimal);

                    if (notes != null && notes.Any())
                        media = notes.Select(n => n.Value).Sum() / notes.Count();

                    Console.WriteLine($"Matricula: {student.Id}, Nome: {student.Name}, Media: {media}");
                }
            }
        }

        private static void CloseSession()
        {
            Console.WriteLine("\nPrograma finalizado.\n");
        }

        private static void InvalidOption()
        {
            Console.WriteLine("\nOpção Inválida.\n");

            ShowOptions();
        }
    }
}
