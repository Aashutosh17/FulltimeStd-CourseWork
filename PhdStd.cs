namespace FullTimeStudentApplication
{
    public class PhDStudent : FullTimeStudent
    {
        public string Dissertation { get; set; }

        public PhDStudent()
        {
            Dissertation = "Exploring UI/UX in Mobile Applications";
        }

        public override string ComputeGrade()
        {
            return "PhD Student Grade: Pass";
        }
    }
}