using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManager.Models
{
    public partial class Weeks
    {
        public string CourseName
        {
            get
            {

                CourseManagerEntities db = new CourseManagerEntities();
                var course = db.Course.Where(t => t.Id == Id).FirstOrDefault();
                if (course == null)
                {
                    return "";

                }
                return course.Name;

            }
        }
    }
}