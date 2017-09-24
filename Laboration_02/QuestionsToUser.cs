using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_02
{
    class QuestionsToUser
    {

       
        public int UserAnswer { get; set; }
        

        /////////////////////////////////////////////
    


        public int ReadUser()
        {
           
           UserAnswer = int.Parse(Console.ReadLine());
           return UserAnswer;
                
        }




    }
}
