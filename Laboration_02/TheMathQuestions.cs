using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_02
{
    class TheMathQuestions
    {
        public int Num01 { get; set; }
        public int Num02 { get; set; }

        public int Num03 { get; set; }
        public int Num04 { get; set; }

        public int Num05 { get; set; }
        public int Num06 { get; set; }

        public int Num07 { get; set; }
        public int Num08 { get; set; }

        public int Num09 { get; set; }
        public int Num10 { get; set; }

       

        QuestionsToUser q = new QuestionsToUser();
        

        public void MathRandom()
        {           
            Random rnd = new Random();
            Num01 = rnd.Next(1, 11);
            Num02 = rnd.Next(1, 11);           
        }

        public void MathRandomStep2()
        {
            Random rnd = new Random();
            Num03 = rnd.Next(1, 23);
            Num04 = rnd.Next(1, 21);
        }

        public void MathRandomStep3()
        {
            Random rnd = new Random();
            Num05 = rnd.Next(1, 43);
            Num06 = rnd.Next(1, 42);
        }

        public void MathRandomStep4()
        {
            Random rnd = new Random();
            Num07 = rnd.Next(1, 55);
            Num08 = rnd.Next(1, 54);
        }

        public void MathRandomStep5()
        {
            Random rnd = new Random();
            Num09 = rnd.Next(1, 123);
            Num10 = rnd.Next(1, 99);
        }






    }
}
