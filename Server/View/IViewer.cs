using ModelCourse;
using System.Collections.Generic;

namespace Server.View
{
    public interface IViewer
    {
        public void View(Course course);
        public void ViewAll(List<Course> course);
    }
}
