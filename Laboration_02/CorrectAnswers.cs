using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_02
{
    
    class CorrectAnswers
    {
       
        public bool CheckAnswer { get; set; }
        public int UserWithAnswer { get; set; }


       QuestionsToUser q = new QuestionsToUser();
       TheMathQuestions rndMath = new TheMathQuestions();
       

        public bool CheckIfAnswerIsTrue(int a, int b, int c)
        {
                    
            CheckAnswer = true;
            if (a == (b + c))
            {
                CheckAnswer = true;
            }
            else
            {
                CheckAnswer = false;
            }
               
                                             
            return CheckAnswer;


        }

        

        

        




    }
}
