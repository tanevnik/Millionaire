using System;
using System.Collections.Generic;

namespace Millionaire
{
    class Model
    {
        List<Question>[] database = new List<Question>[15]; //za sekoe nivo po edna lista so prasanja 
        public int level; //int od 0 do 14, so sekoe tocno odgovoreno prasanje se zgolemuva
        public int questionID; //ID na prasanjeto vo databazata
        int[] money = {500, 1000, 2000, 3000, 5000, 8000, 16000, 32000, 64000, 125000, 250000, 500000, 1000000, 2000000, 4000000};

        public Question currentQuestion; //tekovnoto prasanje vo igrata
        public int correct; //int od 0 do 3 koe oznacuva na koja pozicija se naogja tocniot odgovor
        
        public Model()
        {
            initializeDatabase();
            level = 0;
            questionID = generateQuestionID();
            currentQuestion = getCurrentQuestion();
        }

        private void initializeDatabase()
        {
            //Reads all the questions from the file and stores them in the database array

            //initialize the lists in the database
            for (int i = 0; i < 15; i++) database[i] = new List<Question>();

            //read and parse the questions from the file
            char[] separator = {'~'};
            string[] lines = System.IO.File.ReadAllLines(@"prasanja.txt");
            foreach(string line in lines)
            {
                //parsing the lines
                string[] split = line.Split(separator);
                int level = int.Parse(split[0]);
                string question = split[1];
                string answer = split[2];
                string wrong1 = split[3];
                string wrong2 = split[4];
                string wrong3 = split[5];

                //adding the question in database
                database[level].Add(new Question(question, answer, wrong1, wrong2, wrong3));
            }
        }

        public int generateQuestionID()
        {
            //generates a random question ID for the current level from the database
            //returns the ID of that question
            Random r = new Random();
            return r.Next(database[level].Count);
        }

        public Question getCurrentQuestion()
        {
            //returns the current question with random placements of answers
            Question q = database[level][questionID];

            //random ordering
            Random r = new Random();
            List<string> oldOrder = new List<string>();
            List<string> newOrder = new List<string>();
            foreach (string s in q.answer) oldOrder.Add(s);
            bool foundCorrect = false;
            for (int i = 4; i>0; i--)
            {
                int tmpRandom = r.Next(i);
                if (tmpRandom == 0 && !foundCorrect)
                {
                    foundCorrect = true;
                    correct = newOrder.Count;
                }
                newOrder.Add(oldOrder[tmpRandom]);
                oldOrder.RemoveAt(tmpRandom);
            }

            return new Question(q.question, newOrder[0], newOrder[1], newOrder[2], newOrder[3]);
        }

        //PUBLIC METHODS
        public bool tryAnswer(int ans)
        {
            int tmpCorrect = correct;
            if(ans == correct)
            {
                Console.Write("CORRECT!");
                level++;
                questionID = generateQuestionID();
                currentQuestion = getCurrentQuestion();

                //TODO: trigger animation for questions transition
            }
            else
            {
                Console.Write("WRONG!");
                //TODO: implement wrong answer behaivour
            }

            return ans == tmpCorrect;
        }

        public int getMoney(bool lose)
        {
            //returns the earned money
            if (lose)
            {
                if (level > 9)
                {
                    return money[9]; //zagarantirana suma za 10to prasanje
                }
                else if (level > 4)
                {
                    return money[4]; //zagarantirana suma za 5to prasanje
                }
                else return 0;
            }
            else
            {
                //se otkazal
                if (level == 0) return 0; //se otkazal na 1vo prasanje
                return money[level - 1];
            }
        }
        
    }
}
