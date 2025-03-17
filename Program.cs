using System;
using System.Collections;

namespace FullTimeStudentApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList AList = new ArrayList();

            UGStudent ug1 = new UGStudent();
            Console.Write("Enter UG Student's Marks: ");
            ug1.Score = Convert.ToInt32(Console.ReadLine());
            AList.Add(ug1);

            GStudent gt = new GStudent();
            AList.Add(gt);

            foreach (FullTimeStudent ft in AList)
            {
                if (ft is UGStudent)
                {
                    Console.WriteLine("UG Student Grade: " + ((UGStudent)ft).ComputeGrade());
                }
                else if (ft is GStudent)
                {
                    Console.WriteLine("Thesis Title: " + ((GStudent)ft).Thesis);
                }
            }
        }
    }
}