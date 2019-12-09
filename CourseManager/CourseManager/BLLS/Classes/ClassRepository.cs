using CourseManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManager.BLLS.Classes
{
    public class ClassRepository : IClassRepository
    {
        protected CourseManagerEntities db = new CourseManagerEntities();
        public List<CourseDetail> GetClassCourse(int id)
        {
            var query =
                from cm in db.CourseManagements
                join c in db.Classes
                    on cm.ClassId equals c.Id
                join cr in db.Classes
                    on cm.ClassId equals cr.Id
                join t in db.Classes
                    on cm.ClassId equals t.Id
                where cm.ClassId == id
                select new CourseDetail
                {
                    ClassName = c.Name,
                    CourseName = cr.Name,
                    TeacherName = t.Name
                };
            return query.ToList();
        }
    }
}