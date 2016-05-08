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
        public string[] answer;

        public Question(string q, string a0, string a1, string a2, string a3)
        {
            question = q;
            answer = new string[4];
            answer[0] = a0;
            answer[1] = a1;
            answer[2] = a2;
            answer[3] = a3;
        }
    }
}
