﻿int n = int.Parse(Console.ReadLine());

var names = Console.ReadLine()
     .Split()
     .ToList();

Func<string, int, bool> checker = (name, value) =>
 name.ToCharArray()
.Select(ch => (int)ch).Sum() >= value;

Func<List<string>, int, Func<string, int, bool>, string> namesChecker =
    (names, n, checker) =>
 names.FirstOrDefault(name => checker(name, n));

Console.WriteLine(namesChecker(names, n, checker).ToString());
                  
        