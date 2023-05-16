using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{

    public class Play : IDisposable
    {
        

        // Properties
        public StringBuilder Title { get; set; }
        public StringBuilder TheatreName { get; set; }
        public StringBuilder Genre { get; set; }
        public int Duration { get; set; }
        public List<StringBuilder> Actors { get; set; }

        // Constructor
        public Play(string title, string theatreName, string genre, int duration, List<string> actors)
        {
            Title = new StringBuilder(title);
            TheatreName = new StringBuilder(theatreName);
            Genre = new StringBuilder(genre);
            Duration = duration;
            Actors = new List<StringBuilder>();

            foreach (string actor in actors)
            {
                Actors.Add(new StringBuilder(actor));
            }
        }

        // Methods
        public void Perform()
        {
            Console.WriteLine("Performing the play: " + Title);
            Console.WriteLine("Theatre: " + TheatreName);
            Console.WriteLine("Genre: " + Genre);
            Console.WriteLine("Duration: " + Duration + " minutes");

            Console.WriteLine("Actors:");
            foreach (StringBuilder actor in Actors)
            {
                Console.WriteLine(actor);
            }
        }
        public void Dispose()
        {
            Title.Clear();
            TheatreName.Clear();
            Genre.Clear();
            Actors.Clear();

        }

    }
}
