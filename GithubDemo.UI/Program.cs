namespace GithubDemo.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a new line of code");

            List<Person> list = new();
            Person person1 = new Person()
            {
                FirstName = "Ruben",
                LastName = "Lopes",
                PlaceOfBirth = "Lisbon"
            };

            Person person2 = new Person()
            {
                FirstName = "Ricardo",
                LastName = "Pato",
                PlaceOfBirth = "Lisbon"
            };

            list.Add(person1);
            list.Add(person2);

            foreach (Person person in list)
            {
                Console.WriteLine($"First Name = {person.FirstName}\tLast Name = {person.LastName}\tPlace Of Birth = {person.PlaceOfBirth}");
                Console.WriteLine("Ganda Nice");
                Console.WriteLine("Not Ganda Nice");
                Console.WriteLine("Exemplo de uma nova linha");
            }
            Console.WriteLine("Exemplo de outra nova linha");

        }
    }
}
