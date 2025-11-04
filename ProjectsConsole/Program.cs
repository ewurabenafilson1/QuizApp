using System.IO;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string file = "ProjectsConsole\\questions.txt";
        List<Question> quiz = new List<Question>();
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

            // Clean the answer text
            string correctAnswer = answerLine.Replace("✅ Answer:", "").Trim();
        
        Question question = new Question(questionText, options, correctAnswer);

        // 5️⃣ Add it to our list
        quiz.Add(question);
        }


         

        return quiz;

    }        
}
