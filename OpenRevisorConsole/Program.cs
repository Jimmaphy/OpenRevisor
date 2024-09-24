using OpenRevisorCore;

namespace OpenRevisorConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a simple question and print the text to the console.
            Questions.Question question = Questions.createQuestion("1", "A");
            Console.WriteLine(Questions.getText(question));

            // Let the user put in an answer and check if it is correct.
            string answer = Console.ReadLine() ?? "";
            Console.WriteLine(Questions.isCorrect(question, answer));
        }
    }
}
