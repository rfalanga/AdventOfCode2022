namespace AdventOfCode2022
{
    internal class Day1Part1
    {
        public List<int> Calories { get; set; }

        public Day1Part1()
        {
            Calories= new List<int>();
        }

        public int TotalCalories() => Calories.Sum();
    }
}
