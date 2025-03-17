namespace FullTimeStudentApplication
{
    public class GStudent : FullTimeStudent
    {
        public string Thesis { get; set; }

        public GStudent()
        {
            Thesis = "Advanced Topics in Computer Science";
        }
    }
}