namespace AdventOfCode2022.Tests
{
    public class SimpleUnitTest
    {
        [Fact]
        public void TwoSimpleTests()
        {
            // arrange
            var ef1 = new ElfFood();
            var ef2 = new ElfFood();

            // act
            ef1.Calories.Add(10);
            ef2.Calories.Add(20);

            // assert
            Assert.True(ef1 < ef2, "10 is not less than 20?");
            Assert.False(ef1 > ef2, "10 is less than 20, but thinks it isn't");
        }
    }
}