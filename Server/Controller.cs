using Server.View;
using ModelCourse;

namespace Server
{
    public class Controller
    {
        private ValuteManager ValuteManager;
        private DbManager DbManager;
        private IViewer Viewer;

        public Controller()
        {
            ValuteManager = new ValuteManager();
            DbManager = new DbManager();
            Viewer = new Viewer();
        }

        public void GetAndSaveCurrentCourses()
        {
            if (ValuteManager.GetCourse() is Course rates)
                DbManager.SaveData(rates);
        }

        public void ShowCourses() =>
            Viewer.ViewAll(DbManager.GetCourses());
    }
}
