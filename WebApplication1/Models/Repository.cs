namespace WebApplication1.Models
{
    public class General
    {
        public List<Student> GetStudents()
        {
            var mylist = new List<Student>()
            {
                new Student
                {
                    FirstName = "Mark",
                    LastName =  "Ofori",
                    Address =   "Accra Ridge",
                    Gender =    "Male",
                    DateOfBirth = DateTime.Now,
                    EmailAddress = "natmensah60@gmail.com",
                    NextOfking = "Morrison",
                    Phone = "0245786940",
                    ProgrammeID =  2,
                    StudentID = 4
                },
                new Student
                {
                    FirstName = "Philip",
                    LastName = "Ofori",
                    Address = "Accra Ridge",
                    Gender = "Male",
                    DateOfBirth = DateTime.Now,
                    NextOfking = "Morrison",
                    Phone = "0245786940",
                    ProgrammeID = 2,
                    StudentID = 4
                },
                new Student
                {
                    FirstName = "Clifford",
                    LastName = "Ofori",
                    Address = "Accra Ridge",
                    Gender = "Male",
                    DateOfBirth = DateTime.Now,
                    NextOfking = "Morrison",
                    Phone = "0245786940",
                    ProgrammeID = 2,
                    StudentID = 4
                },
                new Student
                {
                    FirstName = "Mark",
                    LastName = "Ofori",
                    Address = "Accra Ridge",
                    Gender = "Male",
                    DateOfBirth = DateTime.Now,
                    NextOfking = "Morrison",
                    Phone = "0245786940",
                    ProgrammeID = 2,
                    StudentID = 4
                },
            };

            return mylist;  
        }
    }
}
