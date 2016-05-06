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

        //informacii za jokerite
        public bool fifty_spent;
        public bool audience_spent;
        public bool phone_spent;
        public bool switch_spent;

        //informacii za jokerot 50-50
        public bool fifty_active; //oznacuva dali jokerot 50-50 e aktiviran na tekovnoto prasanje
        public int fifty_wrong1; //eden gresen odgovor koj se otstranuva so jokerot 50-50
        public int fifty_wrong2; //drug gresen odgovor koj se otstranuva so jokerot 50-50

        public Model()
        {
            initializeDatabase();
            level = 0;
            generateNewQuestion();
            fifty_spent =  audience_spent = phone_spent = switch_spent = false;
            fifty_active = false;
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

        public void generateNewQuestion()
        {
            //generates a new question for the current level
            fifty_active = false;
            Random r = new Random();

            //generate a random question ID for the current level from the database
            questionID = r.Next(database[level].Count);

            //get the question from the database
            Question q = database[level][questionID];

            //get random ordering
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

            currentQuestion = new Question(q.question, newOrder[0], newOrder[1], newOrder[2], newOrder[3]);
        }

        //PUBLIC METHODS
        public bool tryAnswer(int ans)
        {
            int tmpCorrect = correct;
            if(ans == correct)
            {
                Console.Write("CORRECT!");
                level++;
                if(level < 15) generateNewQuestion();
            }
            else
            {
                Console.Write("WRONG!");
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

        //JOKERS
        public void joker_fifty()
        {
            //disables 2 wrong answers by random
            Random random = new Random();
            fifty_active = true;

            //disable the first wrong answer
            fifty_wrong1 = random.Next(3);
            if (fifty_wrong1 >= correct) fifty_wrong1++;

            //disable the second wrong answer
            fifty_wrong2 = random.Next(2);
            if (fifty_wrong2 >= correct)
            {
                fifty_wrong2++;
                if (fifty_wrong2 >= fifty_wrong1) fifty_wrong2++;
            }
            else if (fifty_wrong2 >= fifty_wrong1)
            {
                fifty_wrong2++;
                if (fifty_wrong2 >= correct) fifty_wrong2++;
            }

            //disable the joker for next questions
            fifty_spent = true;
        }

        public int[] joker_audience()
        {
            int[] percents = { 0, 0, 0, 0 }; //initial state

            if (fifty_active)
            {
                //only two answers remaining
                int[] certain = { 80, 80, 75, 75, 70, 70, 65, 60, 55, 50, 40, 35, 30, 25, 20 }; //percent of the audience that knows the answer for each level
                percents[correct] = certain[level]; //putting the certain people from the audience

                //calculating all the uncertain people's answers randomly
                Random r = new Random();
                for (int counter = certain[level]; counter < 100; counter++)
                {
                    int randomVote = r.Next(2);
                    if (randomVote >= fifty_wrong1)
                    {
                        randomVote++;
                        if (randomVote >= fifty_wrong2) randomVote++;
                    }
                    else if (randomVote >= fifty_wrong2)
                    {
                        randomVote++;
                        if (randomVote >= fifty_wrong1) randomVote++;
                    }
                    percents[randomVote]++;
                }
            }
            else
            {
                int[] certain = { 70, 60, 55, 50, 40, 30, 25, 20, 15, 13, 11, 9, 7, 5, 5 }; //percent of the audience that knows the answer for each level

                percents[correct] = certain[level]; //putting the certain people from the audience

                //calculating all the uncertain people's answers randomly
                Random r = new Random();
                for (int counter = certain[level]; counter < 100; counter++)
                {
                    int randomVote = r.Next(4);
                    percents[randomVote]++;
                }
            }

            //disable the joker for next questions
            audience_spent = true;

            return percents;
        }

        public int[] joker_phone()
        {
            Random r = new Random();
            int variation = (r.Next(3) - 1) * 10; //this gets random value from {-10, 0, 10}
            int[] ret = new int[2];
            if (fifty_active)
            {
                //if 50-50 is active, the friend is more certain
                int[] certain = { 90, 90, 90, 90, 90, 80, 70, 60, 60, 60, 60, 60, 60, 60, 60 }; //certainty of friend
                int[] prob = { 100, 100, 100, 100, 100, 100, 90, 80, 70, 60, 60, 60, 60, 60, 50 }; //probability of right answer
                if(r.Next(100) < prob[level])
                {
                    //correct answer
                    ret[0] = correct;
                    ret[1] = certain[level] + variation;
                }
                else
                {
                    //wrong answer
                    int wrong = r.Next(3);
                    if (wrong <= correct) wrong++;
                    ret[0] = wrong;
                    ret[1] = certain[level] + variation;
                }
            }
            else {
                int[] certain = { 90, 90, 90, 90, 80, 70, 60, 50, 40, 30, 30, 20, 20, 20, 20 }; //certainty of friend
                int[] prob = { 100, 100, 100, 100, 100, 100, 90, 80, 70, 60, 50, 40, 30, 20, 20 }; //probability of right answer
                if (r.Next(100) < prob[level])
                {
                    //correct answer
                    ret[0] = correct;
                    ret[1] = certain[level] + variation;
                }
                else
                {
                    //wrong answer
                    int wrong = r.Next(3);
                    if (wrong <= correct) wrong++;
                    ret[0] = wrong;
                    ret[1] = certain[level] + variation;
                }
            }

            //disable the joker for next questions
            phone_spent = true;

            return ret;
        }

        public void joker_switch()
        {
            //generate a new question with different ID from the current one
            int currentID = questionID;
            while(currentID == questionID)
            {
                generateNewQuestion();
            }

            //disable the joker for next questions
            switch_spent = true;
        }
    }
}
