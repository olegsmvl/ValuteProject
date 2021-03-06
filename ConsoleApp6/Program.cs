using System;
using System.Timers;
using Server.View;

namespace Server
{
    class Program
    {
        private static ValuteManager ValuteManager = new ValuteManager();
        private static DbManager DbManager = new DbManager();

        private static FacadeSystem FacadeSystem;
        static void Main(string[] args)
        {
            Console.WriteLine("Started!");

            ValuteManager valuteManager = new ValuteManager();
            DbManager dbManager = new DbManager();
            IViewer viewer = new Viewer();

            FacadeSystem = new FacadeSystem(valuteManager, dbManager, viewer);

            var timer = new Timer { Interval = 1000 };
            timer.Elapsed += (s, e) => FacadeSystem.GetAndSaveCurrentCourses();
            //timer.Start();

            FacadeSystem.ShowCourses();
            while (true) ;
        }
    }
}
