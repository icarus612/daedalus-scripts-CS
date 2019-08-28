using System;

namespace TrueOrFalse
/*
    Wasn't even gonna save this but it has some solid recursion.
    Bitches love recursion.
 */
{
  class Program
  {
      static string[] questions = {"Eggplants are a type of berry? true or false", "peaches are a type of berry? true or false", "blueberries are a type of berry? true or false", "Eggplants are a type of food? true or false"};
      static bool[] answers = {false, false, true, true};
      static int correct = 0;
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress any key to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below

      for (int i = 0; i < questions.Length; i++){
        QuestionToAsk(i);
      }
      Console.WriteLine($"You got {correct} out of 4 correct");
    }
    static void QuestionToAsk(int i){
      Console.WriteLine(questions[i]);
        string answer = Console.ReadLine();
      	bool isBool;
        if (Boolean.TryParse(answer, out isBool)) {
          if(isBool == answers[i]) correct++;
        } else {
          Console.Write("Make sure to respond with 'true' or 'false'");
          Console.ReadLine();
          QuestionToAsk(i);
        }
    }
    
  }
}
