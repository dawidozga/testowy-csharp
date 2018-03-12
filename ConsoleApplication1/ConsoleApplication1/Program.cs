using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            Diary diary = new Diary();

            diary.AddRating(5);
            diary.AddRating(3);
            diary.AddRating(4.5f);
            diary.AddRating(2);
            diary.AddRating(3);
            diary.AddRating(5);

            Console.WriteLine(diary.CalculateAverage());

            User user1 = new User("elo", "siema", 25);
            User user2 = new User();
            user2.Name = "elo2";

            Console.WriteLine(user1.Name);
            Console.WriteLine(user2.Name);

            Console.WriteLine(Diary.MStatic(1, 3));

            Console.ReadKey();
        }
    }
}
