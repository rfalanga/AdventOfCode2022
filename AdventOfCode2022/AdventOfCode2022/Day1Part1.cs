using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    internal class Day1Part1
    {
        public List<int> Calories { get; set; }

        public Day1Part1()
        {
            Calories= new List<int>();
        }

        public int TotalCalories()
        { return Calories.Sum(); }
    }
}
