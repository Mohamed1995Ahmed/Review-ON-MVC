namespace ABC.FirstProject.Models
{
    public class StudentBL
    {

        public List<Student> GetAll()
        {
            return new List<Student> {
                 new Student { Id = 1, Name = "Ahmed", ImageUrl = "01.jpg" },
                  new Student { Id = 2, Name = "Sara", ImageUrl = "02.jpg" },
                 new Student { Id = 3, Name = "Khaled", ImageUrl = "04.jpg" }

            };



        }
        public Student GetById(int id)
        {
            var x = GetAll().FirstOrDefault(x => x.Id == id);
            return x;
        }
    }
}
