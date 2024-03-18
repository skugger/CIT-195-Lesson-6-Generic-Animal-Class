namespace CIT_195_Lesson_6_Generic_Animal_Class
{
    internal class Program
    {
        public class Animal<T>
        {
            public T info { get; set; }
            public Animal(T info) { this.info = info; }
            public T getAnimal()
            {
                return info;
            }
        }
        static void Main(string[] args)
        {
            Animal<string> animalName = new Animal<string>("Underdog");
            Animal<string> animalHabitat = new Animal<string>("Urbania");
            Animal<bool> animalEndangered = new Animal<bool>(true);
            Animal<bool> animalExtinct = new Animal<bool>(false);
            Animal<int> animalLifespan = new Animal<int>(20);

            Console.WriteLine("Animal Name: " + animalName.getAnimal());
            Console.WriteLine("Animal Habitat: " + animalHabitat.getAnimal());
            Console.WriteLine("Is Animal Endangered? " + animalEndangered.getAnimal());
            Console.WriteLine("Is Animal Extinct? " + animalExtinct.getAnimal());
            Console.WriteLine("Animal Lifespan: " + animalLifespan.getAnimal());
        }
    }
}