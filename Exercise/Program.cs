namespace Demo
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                FirstName == person.FirstName &&
                LastName == person.LastName &&
                Age == person.Age;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName, Age);
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, Age: {Age}";
        }
    }

    class Program
    {
        static void Main()
        {
            var person1 = new Person { FirstName = "John", LastName = "Doe", Age = 30 };
            var person2 = new Person { FirstName = "John", LastName = "Smith", Age = 30 };

            Console.WriteLine(person1.Equals(person2)); 

            var people = new List<Person> { person1, person2 };
            foreach (var p in people)
            {
                if (p is Person { Age: >= 18 })
                {
                    Console.WriteLine($"{p.FirstName} is an adult.");
                }
            }
        }
    }
}