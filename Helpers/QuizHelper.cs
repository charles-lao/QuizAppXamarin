using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizAppXamarin.Helpers
{
    public class QuizHelper
    {
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
    }
}