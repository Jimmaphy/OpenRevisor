using Microsoft.FSharp.Collections;
using Microsoft.FSharp.Core;
using OpenRevisorCore;

namespace OpenRevisorConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a simple question and print the text to the console.
            FSharpResult<Questions.Question, Questions.QuestionError> question1 = Questions.createQuestion("1", "A");
            //Questions.Question question2 = Questions.createQuestion("2", "B");

            //// Create a simple list and print the text to the console.
            //FSharpList<Questions.Question> list = Lists.createQuestionList();
            //list = Lists.addQuestion(list, question1);
            //list = Lists.addQuestion(list, question2);

            //list.ToList().ForEach(q => System.Console.WriteLine(Questions.getText(q)));
        }
    }
}
