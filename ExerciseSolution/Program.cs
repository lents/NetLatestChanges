var person1 = new Person("John", "Doe", 30);
var person2 = person1 with { LastName = "Smith" }; // Копирование с изменением

Console.WriteLine(person1 == person2); // Проверка равенства (record делает это по значению)

var people = new List<Person> { person1, person2 };
foreach (var p in people)
{    
    if (p is { Age: >= 18 })// Проверка возраста с использованием реляционного паттерна
    {
        Console.WriteLine($"{p.FirstName} is an adult.");
    }
}
public record Person(string FirstName, string LastName, int Age);// Заменяем класс на record с init-свойствами