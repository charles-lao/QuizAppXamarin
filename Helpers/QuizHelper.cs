using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using QuizAppXamarin.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizAppXamarin.Helpers
{
    public class QuizHelper
    {
        List<Question> History;
        List<Question> Geography;
        List<Question> Space;
        List<Question> Programming;
        List<Question> Engineering;
        List<Question> Business;

        public string GetTopicDescription(string topic)
        {
            string topicDescription = "";

            if (topic == "History")
            {
                topicDescription = "History is the study of past events, particularly in human affairs. It's a record of human experiences, societies, and cultures over time. History helps us understand how past events shape our present and future, providing context for current issues and decisions.";

            }
            else if (topic == "Space")
            {
                topicDescription = "Space is the vast, seemingly infinite expanse that exists beyond Earth's atmosphere. It is a near-perfect vacuum, containing celestial bodies such as stars, planets, moons, asteroids, and galaxies. Space exploration has expanded our understanding of the universe, revealing phenomena like black holes, dark matter, and the Big Bang.";

            }
            else if (topic == "Geography")
            {
                topicDescription = "Geography is the study of the Earth's landscapes, environments, and the relationships between people and their environments. It encompasses both physical geography, which examines natural features like mountains, rivers, and climates, and human geography, which explores how human culture interacts with the environment.";

            }
            else if (topic == "Programming")
            {
                topicDescription = "Programming is the process of creating instructions for computers to perform specific tasks. It involves writing code in various programming languages such as Python, Java, C++, and JavaScript. Programming enables the development of software applications, websites, games, and more.";

            }
            else if (topic == "Engineering")
            {
                topicDescription = "Engineering is the application of scientific and mathematical principles to design, build, and maintain structures, machines, systems, and processes. It encompasses various disciplines such as civil, mechanical, electrical, chemical, and aerospace engineering.";

            }
            else if (topic == "Business")
            {
                topicDescription = "Business refers to the organized effort of individuals to produce and sell goods or services for profit. It encompasses various activities such as marketing, finance, operations, human resources, and management. Businesses can range from small startups to large multinational corporations.";
            }

            return topicDescription;
        }

        public List<Question> GetQuizQuestions(string topic)
        {
            List<Question> quizList = new List<Question>();

            if(topic == "History")
            {
                InitializeHistory();
                quizList = History;
            }
            else if (topic == "Space")
            {
                InitializeSpace();
                quizList = Space;
            }
            else if (topic == "Geography")
            {
                InitializeGeography();
                quizList = Geography;
            }


            return quizList;
        }

        void InitializeHistory()
        {
            History = new List<Question>();
            History.Add(new Question { QuizQuestion = "During which decade was slavery abolished in the United States?", Answer = "1860s", OptionA = "1860s", OptionB = "1840s", OptionC = "1850s", OptionD = "1870" });
            History.Add(new Question { QuizQuestion = "During which year did Christopher Columbus first arrive in the Americas?", Answer = "1495", OptionA = "1495", OptionB = "1492", OptionC = "1498", OptionD = "1501" });
            History.Add(new Question { QuizQuestion = "Which year was the first edition of FIFA World Cup played", Answer = "1930", OptionA = "1985", OptionB = "1920", OptionC = "1930", OptionD = "2002" });
            History.Add(new Question { QuizQuestion = "World War II also known as the Second World War, was a global war that lasted from 1939 to ?", Answer = "1945", OptionA = "1986", OptionB = "1922", OptionC = "1945", OptionD = "1939" });
            History.Add(new Question { QuizQuestion = "The assassination of Julius Caesar was the result of a conspiracy by many Roman senators, he was stabbed by?", Answer = "Junius Brutus", OptionA = "Uchenna Nnodim", OptionB = "Cassius Longinus", OptionC = "Junius Brutus", OptionD = "Orsa Kemi" });
        }

        void InitializeGeography()
        {
            Geography = new List<Question>();
            Geography.Add(new Question { QuizQuestion = "What is the largest country in the world (by Area)?", Answer = "Russia", OptionA = "Russia", OptionB = "Canada", OptionC = "United Sates", OptionD = "China" });
            Geography.Add(new Question { QuizQuestion = "Which of the following countries does NOT have a population exceeding 200 million?", Answer = "Nigeria", OptionA = "Brazil", OptionB = "Indonesia", OptionC = "Pakistan", OptionD = "Nigeria" });
            Geography.Add(new Question { QuizQuestion = "Muscat is the capital of which country?", Answer = "Oman", OptionA = "Oman", OptionB = "Jordan", OptionC = "Yemen", OptionD = "Bahrain" });
            Geography.Add(new Question { QuizQuestion = "Which is the world's smallest continent (by area)?", Answer = "Oceania", OptionA = "Oceania", OptionB = "Antractica", OptionC = "South America", OptionD = "Europe" });
            Geography.Add(new Question { QuizQuestion = "Which of the following countries is NOT a member state of the European Union?", Answer = "Norway", OptionA = "Finland", OptionB = "Sweden", OptionC = "Norway", OptionD = "Denmark" });

        }

        void InitializeSpace()
        {
            Space = new List<Question>();
            Space.Add(new Question { QuizQuestion = "Who was the first man to ever walk on the Moon?", Answer = "Niel Armstrong", OptionA = "Uchenna Nnodim", OptionB = "Niel Armstrong", OptionC = "Benjamin Franklin", OptionD = "Pele Pele" });
            Space.Add(new Question { QuizQuestion = "The coldest and farthest Planet from the Sun is ?", Answer = "Pluto", OptionA = "Earth", OptionB = "Pluto", OptionC = "Neptune", OptionD = "Saturn" });
            Space.Add(new Question { QuizQuestion = "The galaxy that contains Solar System which Earth belongs to is called what?", Answer = "Milky Way", OptionA = "Chocolate Path", OptionB = "Phantom Zone", OptionC = "Milky Way", OptionD = "Solar Container" });
            Space.Add(new Question { QuizQuestion = "How many days does it take the Earth to complete her orbit", Answer = "365 Days", OptionA = "365 Days", OptionB = "30 Days", OptionC = "272 Days", OptionD = "None of the Above" });
            Space.Add(new Question { QuizQuestion = "An explosion which leads to gigantic explosion throwing star's outer layers are thrown out is called", Answer = "Supernova", OptionA = "Black hole", OptionB = "Double ring", OptionC = "Massive Explosion", OptionD = "Supernova" });

        }
    }
}