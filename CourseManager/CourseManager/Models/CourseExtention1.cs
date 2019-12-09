using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManager.Models
{
    public partial class CourseManagements
    {
        public string ClassName
        {
            get
            {

                CourseManagerEntities db = new CourseManagerEntities();
                var course = db.Classes.Where(t => t.Id == Id).FirstOrDefault();
                if (course == null)
                {
                    return "";

                }
                return course.Name;

            }
        }
    }
}