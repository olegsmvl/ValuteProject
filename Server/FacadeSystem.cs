using Server.View;
using Server.Calculator;

namespace Server
{
    public class FacadeSystem
    {
        private ValuteManager ValuteManager;
        private DbManager DbManager;
        private IViewer Viewer;

        public FacadeSystem(ValuteManager valuteManager, DbManager dbManager, IViewer viewer)
        {
            ValuteManager = valuteManager;
            DbManager = dbManager;
            Viewer = viewer;
        }

        public void GetAndSaveCurrentCourses()
        {
            var rates = ValuteManager.GetCourse();

            if (rates == null) return;

            //var developer = new EurDeveloper("Производитель eur обменников");
            //var exchanger = developer.Create();

            //Console.WriteLine(exchanger.ShowExchangeRate(rates));
            DbManager.SaveData(rates);
        }

        public void ShowCourses()
        {
            var list = DbManager.GetCourses();
            Viewer.ViewAll(list);

            //var behaveor = new Summator();
            //var cal = new CalculatorClass(behaveor);
            //cal.PrintSolve();
        }
    }
}
