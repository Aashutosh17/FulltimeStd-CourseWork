namespace FullTimeStudentApplication
{
    public class UGStudent : FullTimeStudent
    {
        public int Score { get; set; }

        public override string ComputeGrade()
        {
            if (Score >= 95)
                return "A";
            else if (Score >= 90)
                return "A-";
            else if (Score >= 85)
                return "B";
            else if (Score >= 80)
                return "B-";
            else if (Score >= 75)
                return "C";
            else if (Score >= 70)
                return "C-";
            else if (Score >= 65)
                return "D";
            else if (Score >= 60)
                return "D-";
            else
                return "F";
        }
    }
}