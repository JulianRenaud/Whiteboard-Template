using System.Reflection;
using Test_Template;
using Whiteboard_Template;



internal class Program
{
    public static bool tryAgain1 { get; set; }
    public static bool tryAgain2 { get; set; }
    
    private static void Main(string[] args)
    {
        tryAgain1 = true;
        tryAgain2 = true;

        Intro.IntroM();

        while (tryAgain1)
        {
            UserInput.Input();

            if (UserInput.Input2 == true)
            {
                Answer.AnswerM();


            }
            else
            {
                Error1.Error();
                TryAgain.TryAgainM();
            }
        }
        End.EndM();
    }
}