using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_02
{
    class Program
    {



        private static int score = 500;
        const int addScore = 100;

        static int Answer { get; set; }
       
               

        static CorrectAnswers correctAnswer = new CorrectAnswers();
        static QuestionsToUser q = new QuestionsToUser();
        static TheMathQuestions r = new TheMathQuestions();



        static void Main(string[] args)
        {


            WelcomeMessage();


            bool loopTheProgram = true;

            while (loopTheProgram)
            {

             
                r.MathRandom();

                Console.Write(" What is {0} + {1}: ",r.Num01,r.Num02);
                Answer = int.Parse(Console.ReadLine());
                                         
                
                correctAnswer.CheckIfAnswerIsTrue(Answer, r.Num01, r.Num02);
                AddOrNotScore();
                Console.WriteLine(" " + score);
                WinOrEnd();
               


                Console.Write(" Continue: y:  Quit: n: "); //Exit program or not.
                string quitYesOrNo = Console.ReadLine();
                switch (quitYesOrNo)
                {
                    case "y":
                        loopTheProgram = true;
                        break;
                    case "n":
                        loopTheProgram = false;
                        break;
                }

            }

            Console.ReadLine();
        }
        /////////////////////////////////////////////////////////

       

        static void AddOrNotScore() // Gives Or Takes Points To the Score!
        {
            if(correctAnswer.CheckAnswer == true)
            {
                for (int i = 0; i < addScore; i++)
                {
                    score++;
                }
            }
            else
            {
                for (int i = 0; i < addScore; i++)
                {
                    score--;
                }
            }
        }

        

        static void WinOrEnd() //When you win or loose 
        {
            if (score >= 1000)
            {
                score -= 500;
                Console.WriteLine(" <> YOU WIN! <> YOU WIN! <> YOU WIN! <> YOU WIN! <>");
                WelcomeMessage();
            }
            else if(score == 0)
            {
                score += 500;
                Console.WriteLine("<> YOU LOOSE <> YOU LOOSE <> YOU LOOSE <> YOU LOOSE <>");
                WelcomeMessage();
            }

        }

        static void PrintOut(string k)
        {
            Console.WriteLine(k);
        }

        static void WelcomeMessage()
        {
            Console.WriteLine(" <><><><><><><><><><><><><><><><><><><><><><><><><><<> ");
            Console.WriteLine(" <> The Awsome Super Difficult Game                 <>" + //Welcome Message
                   "\n <> The Mission is to answer the correct numbers    <>" +
                   "\n <> you start with 500 points                       <>" +
                   "\n <> Correct answer 100 points                       <>" +
                   "\n <> Incorrect -100 points                           <>" +
                   "\n <> first to 1000 points and you WIN!               <>");
            Console.WriteLine(" <><><><><><><><><><><><><><><><><><><><><><><><><><<>");
            Console.WriteLine("");
            
        }


    }
}
