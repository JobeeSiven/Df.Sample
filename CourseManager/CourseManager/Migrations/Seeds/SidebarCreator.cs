using CourseManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManager.Migrations.Seeds
{
    public class SidebarCreator
    {

        private readonly CourseManager.Models.CourseManagerEntities _context;
        public SidebarCreator(CourseManager.Models.CourseManagerEntities context)
        {
            _context = context;
        }

        public void Seed()
        {
            var initialSidebars = new List<Sidebars>
            {
                new Sidebars
                {
               
                    Name = "班级管理",

                    Controller = "Class",

                    Action = "Index"
                },
                new Sidebars
                {

                    Name = "老师管理",

                    Controller = "Teacher",

                    Action = "Index"
                },
                new Sidebars
                {

                    Name = "学生管理",

                    Controller = "Student",

                    Action = "Index"
                },
                new Sidebars
                {

                    Name = "科目管理",

                    Controller = "Courses",

                    Action = "Index"
                },
                new Sidebars
                {

                    Name = "课程安排",

                    Controller = "CourseManagement",

                    Action = "Index"
                },
                new Sidebars
                {

                    Name = "顶部导航栏管理",

                    Controller = "ActionLinks",

                    Action = "Index"
                },
                new Sidebars
                {

                    Name = "侧边栏管理",

                    Controller = "Sidebars",

                    Action = "Index"
                },

            };
            foreach (var bar in initialSidebars)
            {
                if (_context.Sidebars.Any(r => r.Name == bar.Name))
                {
                    continue;
                }
                _context.Sidebars.Add(bar);
            }
            _context.SaveChanges();
        }
    }
}