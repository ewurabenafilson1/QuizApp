using System.IO;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

class Program
{
    static void Main()
    {
        string file = "ProjectsConsole\\questions.txt";
        List<Question> quiz = LoadQuestions();

        int score = 0;

        foreach (var q in quiz)
        {
            Console.WriteLine(q.Text);
            foreach (var opt in q.Options)
            {
                Console.WriteLine(opt);
            }

            Console.WriteLine("Choose your answer(A/B/C/D): ");
            string choice = Console.ReadLine().Trim().ToUpper();

            if (q.CorrectAnswer.ToUpper().Contains(choice))
            {
                Console.WriteLine("Correct✅");
                score++;
            }
            else
            {
                Console.WriteLine("Wrong❌");
            }
        }
        Console.WriteLine($"\nQuiz completed! You scored {score}");
        if (score == 25)
        {
            Console.WriteLine("Good job!");
        }
        else
        {
            Console.WriteLine("Good luck next time!");
        }

        

       
    }

    static List<Question> LoadQuestions()
    {
        string[] file = File.ReadAllLines("questions.txt");
        List<Question> quiz = new List<Question>();

        for (int i = 0; i < file.Length;)
        {
            if (string.IsNullOrWhiteSpace(file[i]))
            {
                i++;
                continue;
            }

            string questionText = file[i++];

            string[] options = new string[4];
            for (int j = 0; j < 4; j++)
            {
                options[j] = file[i++];
            }

            string answerLine = file[i++].Trim();


            string correctAnswer = answerLine;
        
        Question question = new Question(questionText, options, correctAnswer);

        quiz.Add(question);
        }


         

        return quiz;

    }        
}
