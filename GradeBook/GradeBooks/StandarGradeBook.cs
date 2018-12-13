using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandarGradeBook : BaseGradeBook
    {
		public StandarGradeBook(string name) : base(name)
		{
			Type = GradeBookType.Standard;
		}
    }
}
