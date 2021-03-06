using ModelCourse;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Server.View
{
    public class Viewer : IViewer
    {
        public void View(Course rates)
        {
            string text = $"{rates.Date} {rates.Timestamp} {rates.Valute.USD.Name} {rates.Valute.USD.Value}";
            Console.WriteLine(text);
        }

        public void ViewAll(List<Course> courses)
        {
            foreach (var rate in courses)
            {
                string text = $"{rate.Date} {rate.Timestamp}";
                Console.WriteLine(text);
            }
        }
    }
}
