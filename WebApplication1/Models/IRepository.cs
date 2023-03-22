namespace WebApplication1.Models
{
    public interface IRepository
    {
        public Student AddStudent(Student student);
        public IEnumerable<Student> GetStudents();
        public Student GetStudent(int Id);

        public Student EditStudent(Student student);

        public Student DeleteStudent(int Id);
    }
}
