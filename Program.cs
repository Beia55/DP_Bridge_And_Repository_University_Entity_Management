using System;

namespace BaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            StudentRepository studentRepository = new StudentRepository(new CSV());
            studentRepository.Insert(new Student(2, "Beia"));

            ProfessorRepository professorRepository = new ProfessorRepository(new DB());
            professorRepository.Insert(new Professor("IProfName1", "inginerie"));

        }
    }
}
