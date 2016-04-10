using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    class Question
    {
        public string question;
        public string correctAns;
        public string wrongAns1;
        public string wrongAns2;
        public string wrongAns3;

        public Question(string q, string a, string w1, string w2, string w3)
        {
            question = q;
            correctAns = a;
            wrongAns1 = w1;
            wrongAns2 = w2;
            wrongAns3 = w3;
        }
    }
}
