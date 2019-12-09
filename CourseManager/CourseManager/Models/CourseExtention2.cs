using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManager.Models
{
    public partial class CourseManagements
    {
        public string TeacherName
        {
            get
            {

                CourseManagerEntities db = new CourseManagerEntities();
                var course = db.Teachers.Where(t => t.TeacherId == TeacherId).FirstOrDefault();
                if (course == null)
                {
                    return "";

                }
                return course.Name;

            }
        }
    }
}