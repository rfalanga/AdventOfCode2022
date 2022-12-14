using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Tests
{
    public class ListOfCaloriesUnitTest
    {
        [Fact]
        public void ComplicatedTests()
        {
            // arrange
            var Elf1 = new ElfFood();
            var Elf2 = new ElfFood();
            var Elf3 = new ElfFood();

            // act
            Elf1.Calories.Add(10);
            Elf1.Calories.Add(15);
            Elf1.Calories.Add(20);
            Elf2.Calories.Add(30);
            Elf2.Calories.Add(40);
            Elf3.Calories.Add(7);
            Elf3.Calories.Add(8);
            Elf3.Calories.Add(9);
            Elf3.Calories.Add(10);

            var Elves = new List<ElfFood?>();
            Elves.Add(Elf1);
            Elves.Add(Elf2);
            Elves.Add(Elf3);

            // assert
        }
    }
}
