using System;

namespace ConsoleApp1
{
    public class Organization
    {
        private string[] questions;
        private string[] answers;

        public Organization(int size)
        {
            questions = new string[size];
            answers = new string[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter Question {0}:", i + 1);
                string question = Console.ReadLine();
                questions[i] = question;
                
                for (int j = 0; j < size; j++)
                {
                    Console.WriteLine("Enter Answer {0}:", j + 1);
                    string answer = Console.ReadLine();
                    answers[j] = answer;
                    break;
                }
            }
        }

        public void GetQuestions()
        {
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine("Question {0}: {1}", i + 1, questions[i]);
            }
        }
        public void GetAnswers()
        {
            for (int i = 0; i < answers.Length; i++)
            {
                Console.WriteLine("Answer {0}: {1}", i + 1, answers[i]);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of questions:");
            int Questions = int.Parse(Console.ReadLine());

            Organization obj = new Organization(Questions);
            obj.GetQuestions();
            obj.GetAnswers();
            Console.ReadLine();

        }
    }
}
