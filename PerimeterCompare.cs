using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Task1
{
    public class PerimeterCompare : IComparer<Square>
    {
        public int Compare(Square s1, Square s2)
        {
            if (s1.GetPerimeter > s2.GetPerimeter)
                return 1;
            else if (s1.GetPerimeter < s2.GetPerimeter)
                return -1;
            else
                return 0;
        }
    }
}
