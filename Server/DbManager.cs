using System;
using System.Collections.Generic;
using System.Text;
using ModelCourse;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Server
{
    public class DbManager
    {
        public void SaveData(Course course)
        {
            using (var db = new Context())
            {
                db.Courses.Add(course);
                db.SaveChanges();
            }
        }

        public List<Course> GetCourses()
        {
            using (var db  = new Context())
            {
                return db.Courses.ToList();
            }
        }
    }
}
