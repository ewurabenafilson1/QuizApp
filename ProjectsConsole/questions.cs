class Question
{
    public string Text { get; set; }
    public string[] Options { get; set; }

    public string CorrectAnswer { get; set; }
    
    public Question(string text, string[] options, string correctAnswer)
    {
        Text = text;
        Options = options;
        CorrectAnswer = correctAnswer;
    }

}