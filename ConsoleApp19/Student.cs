﻿using System.Text.RegularExpressions;

namespace ConsoleApp19;

public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int GroupId { get; set; }
    public Group Group { get; set; }
}
