// See https://aka.ms/new-console-template for more information

using AdventOfCode2022;

//List<ElfFood> day1Part1s = DoDay1Part1();
//Console.WriteLine($"Maximum calories an Elf is carry is: {MaximumCalories(day1Part1s)}");

Console.WriteLine($"The top 3 Elves total calories are {DoDay1Part2()}");

//Read through the Day 1, Part 1 input file. This returns the list of ElfFood in an unordered list
List<ElfFood> DoDay1Part1()
{
    var tmpList = new List<ElfFood>();

    string[] lines = ReadInputFile();

    //read through data, populating the list as needed
    int position = 0;
    tmpList.Add(new ElfFood());
    for (int i = 0; i < lines.Length; i++)
    {
        var line = lines[i];

        if (string.IsNullOrEmpty(line))
        {
            tmpList.Add(new ElfFood());
            position++;
        }
        else
        {
            int tmp = int.Parse(line);
            tmpList[position].Calories.Add(tmp);
        }
    }

    return tmpList;
}

// Return the top 3 elves with calories
int DoDay1Part2()
{
    var unOrderedElfFoodList = DoDay1Part1();
    var orderedList = unOrderedElfFoodList;

    orderedList.Sort();
    orderedList.Reverse();

    return orderedList[0].TotalCalories() + orderedList[1].TotalCalories() + orderedList[2].TotalCalories();
}

int MaximumCalories(List<ElfFood> list)
{
    int max = 0;

    foreach (var item in list)
    {
        max = int.Max(max, item.TotalCalories());
    }

    return max;
}

static string[] ReadInputFile()
{
#pragma warning disable CS8602 // Dereference of a possibly null reference.
    string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    string txtFilePath = path.Replace("\\bin", "\\Assets\\Day1 input.txt");

    string[] lines = File.ReadAllLines(txtFilePath);
    return lines;
}