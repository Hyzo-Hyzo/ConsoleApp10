namespace ConsoleApp10
{
    using System;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Task1");
            using (Film film = new Film("Х", "Studio Name", "Film Genre", 120, 2023))
            {

                Console.WriteLine("Film information:");
                Console.WriteLine("Title: " + film.Title);
                Console.WriteLine("Studio Name: " + film.StudioName);
                Console.WriteLine("Genre: " + film.Genre);
                Console.WriteLine("Duration: " + film.Duration);
                Console.WriteLine("Year: " + film.Year);

                film.Play();
                film.Stop();
            }
            //2
            Console.WriteLine("Task2");
            List<string> actors = new List<string> { "Мария Константиновна Заньковецкая", "Богдан Сильвестрович Ступка", "Ирма Григорьевна Витовская" };

            using (Play play = new Play("Х", "Theatre Name", "Play Genre", 120, actors))
            {
                play.Perform();
            }
            Console.ReadLine();
        }
    }
}