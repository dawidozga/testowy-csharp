using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Diary
    {
        private List<float> ratings = new List<float>();
        
        // <Metody

        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        public float CalculateAverage()
        {
            float average = ratings.Count > 0 ? ratings.Average() : 0.0f;

            return average;
        }

        public static int MStatic (int val1, int val2)
        {
            return val1 + val2;
        }
    }
}
