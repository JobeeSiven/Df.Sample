namespace CourseManager.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CourseManagerEntities : DbContext
    {
        public CourseManagerEntities()
            : base("name=CourseManagerContext")
        {
        }

        public virtual DbSet<ActionLinks> ActionLinks { get; set; }
        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<CourseManagements> CourseManagements { get; set; }
        public virtual DbSet<Sidebars> Sidebars { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Weeks> Weeks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
