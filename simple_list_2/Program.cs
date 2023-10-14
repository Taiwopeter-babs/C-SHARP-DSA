using SimpleList2;

public class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();
        people.Add(new Person() { Name = "Taiwo", Age = 20, Country = CountryEnum.NIG });
        people.Add(new Person() { Name = "Yvonne", Age = 22, Country = CountryEnum.GH });
        people.Add(new Person() { Name = "Shali", Age = 23, Country = CountryEnum.KEN });
        people.Add(new Person() { Name = "Mustapha", Age = 29, Country = CountryEnum.NIG });
        people.Add(new Person() { Name = "Appiah", Age = 27, Country = CountryEnum.GH });
        people.Add(new Person() { Name = "Esther", Age = 24, Country = CountryEnum.KEN });

        List<Person> results = people.OrderBy(person => person.Age).ToList();
        foreach (Person person in results)
        {
            Console.WriteLine($"{person.Name} from {person.Country} is {person.Age}");
        }
    }
}