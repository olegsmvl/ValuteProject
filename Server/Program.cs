using System;
using System.Timers;
using Server.View;
using Server.Settings;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started!");

            var settingsManager = new SettingsManager(Config.SettingsFilename, Config.DefaultSettings);
            var controler = new Controller();

            var timer = new Timer { Interval = settingsManager.LoadSettings().IntervalSec };
            timer.Elapsed += (s, e) => controler.GetAndSaveCurrentCourses();
            //timer.Start();

            controler.ShowCourses();
            while (true) ;
        }
    }
}
