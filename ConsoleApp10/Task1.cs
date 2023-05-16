using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Film : IDisposable
    {
        

        public StringBuilder Title { get; set; }
        public StringBuilder StudioName { get; set; }
        public StringBuilder Genre { get; set; }
        public StringBuilder Duration { get; set; }
        public StringBuilder Year { get; set; }

        // Constructor
        public Film(string title, string studioName, string genre, int duration, int year)
        {
            Title = new StringBuilder(title);
            StudioName = new StringBuilder(studioName);
            Genre = new StringBuilder(genre);
            Duration = new StringBuilder(duration.ToString());
            Year = new StringBuilder(year.ToString());
        }

        public void Play()
        {
            Console.WriteLine("Playing the film: " + Title.ToString());
        }

        public void Stop()
        {
            Console.WriteLine("Stopping the film: " + Title.ToString());
        }
    
        public void Dispose()
        {
           Title.Clear();
            StudioName.Clear();
            Genre.Clear();
            Duration.Clear();
            Year.Clear();

        }
       
    }
}
