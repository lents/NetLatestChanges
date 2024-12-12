int[] numbers = { 1, 2, 3, 4, 5 };

var slice = numbers[1..4];
Console.WriteLine(string.Join(", ", slice)); 

var last = numbers[^1]; 
Console.WriteLine(last);
