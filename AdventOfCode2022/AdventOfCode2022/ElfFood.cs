namespace AdventOfCode2022
{
    internal class ElfFood : IComparable<ElfFood>
    {
        public List<int> Calories { get; set; }

        public ElfFood()
        {
            Calories= new List<int>();
        }

        public int TotalCalories() => Calories.Sum();

        /*
         * Need to add the ability to compare on ElfFood's TotalCalories to another. Following this example:
         * https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1?view=net-7.0
         */
        public int CompareTo(ElfFood? other)
        {
            if (other == null)
            {
                return 1;
            }

            return TotalCalories().CompareTo(other.TotalCalories());
        }

        public static bool operator > (ElfFood left, ElfFood right)
        {
            return left.CompareTo(right) > 0;
        }

        public static bool operator < (ElfFood left, ElfFood right)
        {
            return left.CompareTo(right) < 0;
        }

        public static bool operator >= (ElfFood left, ElfFood right)
        {
            return left.CompareTo(right) >= 0;
        }

        public static bool operator <= (ElfFood left, ElfFood right)
        {
            return left.CompareTo(right) <= 0;
        }
    }
}
