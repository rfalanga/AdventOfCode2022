// See https://aka.ms/new-console-template for more information

using AdventOfCode2022;

List<Day1Part1>? day1Part1s = null;

day1Part1s = DoDay1Part1();


//Read through the Day 1, Part 1 input file
List<Day1Part1>? DoDay1Part1()
{
    var tmpList = new List<Day1Part1>();

    string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
    string txtFilePath = path.Replace("\\bin", "\\Assets\\Day1 input.txt");

    string[] lines = File.ReadAllLines(txtFilePath);

    //read through data, populating the list as needed


    return tmpList;
}
