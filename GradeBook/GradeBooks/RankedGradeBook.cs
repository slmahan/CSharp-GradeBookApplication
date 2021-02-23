using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            double studentsPerLetterGrade;
            studentsPerLetterGrade = Students.Count / 5;
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("Must have at least 5 students for ranked grading");
            }
         



            return 'F';
        }
    }
}
