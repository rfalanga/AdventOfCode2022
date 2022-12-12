// See https://aka.ms/new-console-template for more information

using AdventOfCode2022;

List<ElfFood> day1Part1s = DoDay1Part1();
Console.WriteLine($"Maximum calories an Elf is carry is: {MaximumCalories(day1Part1s)}");


//Read through the Day 1, Part 1 input file
List<ElfFood> DoDay1Part1()
{
    var tmpList = new List<ElfFood>();

    string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
    string txtFilePath = path.Replace("\\bin", "\\Assets\\Day1 input.txt");

    string[] lines = File.ReadAllLines(txtFilePath);

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

int MaximumCalories(List<ElfFood> list)
{
    int max = 0;

    foreach (var item in list)
    {
        max = int.Max(max, item.TotalCalories());
    }

    return max;
}
