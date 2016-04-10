using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millionaire
{
    class Model
    {
        List<Question>[] database = new List<Question>[15]; //za sekoe nivo po edna lista so prasanja 
        int level; //od 1 do 15, so sekoe tocno odgovoreno prasanje se zgolemuva
        int questionID; //ID na prasanjeto
        
        public Model()
        {
            initializeDatabase();
            level = 0;
            questionID = generateQuestionID();
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

        private int generateQuestionID()
        {
            //generates a random question ID for the current level from the database
            //returns the ID of that question
            Random r = new Random();
            return r.Next(database[level].Count);
        }

        //PUBLIC METHODS
        public Question getCurrentQuestion()
        {
            //returns the current question
            return database[level][questionID];
        }
    }
}
