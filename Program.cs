using System;
using OverloadingOperators;

// int a = 3;
// int b = 2;

// int c = a + b;

// Console.WriteLine(c);

// string s1 = "Hello";
// string s2 = " ";
// string s3 = "There!";

// string complete = s1 + s2 + s3;

// Console.WriteLine(complete);

Point first = new(100, 200);
Point second = new(50, 150);

Console.WriteLine($"First Point: {first}");
Console.WriteLine($"Second Point: {second}");

Point third = first + second;
Console.WriteLine($"Third Point: {third}");

Point fourth = first - second;
Console.WriteLine($"Fourht Point: {fourth}");

Point fifth = first + 50;
Console.WriteLine($"Fifth Point: {fifth}");

Point sixth = 50 + first;
Console.WriteLine($"sixth Point: {sixth}");