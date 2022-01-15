using Course.Shared;

namespace Course.Server.Services
{
    public class TeacherService
    {
        private Db Db { get; set; }
        public TeacherService(Db db)
        {
            Db = db;
        }
        public List<Teacher> GettingTeachers()
            => Db.Teachers.ToList();
    }
}

