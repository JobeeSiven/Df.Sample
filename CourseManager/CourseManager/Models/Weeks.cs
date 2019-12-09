using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManager.Models
{
    public partial class Weeks
    {
        public int Id { get; set; }

        public string WeekId { get; set; }

        public string SectionId { get; set; }

        public string CourseId { get; set; }
    }
}