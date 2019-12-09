using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManager.Models
{
    public partial class Students
    {
        public string ClassName
        {
            get
            {
                CourseManagerEntities db = new CourseManagerEntities();
                var calsses = db.Classes.Where(t => t.Id == Id).FirstOrDefault();
                if (calsses == null)
                {
                    return "";

                }
                

                return calsses.Name;

            }
        }
    }
}