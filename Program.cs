// Quick intro to objects for reference

using System;

namespace objects_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate new cat object with properties for noise and color
            Animal cat = new Animal("meow", "black");
            // Instantiate new dog object with values for noise, color, age
            Animal dog = new Animal("woof", "golden", 4);

            // New monkey object with no values set
            Animal monkey = new Animal();
            
            // Using SayNoise method of Animal Object
            cat.SayNoise();
            dog.SayNoise();

            // set monkey HP to 100
            monkey.HP = 100;
            monkey.TakeDamage(damageCalc());
            monkey.TakeDamage(10);
        }

        static int damageCalc(){
            return 4;
        }
    }

    public class Animal{

        // Getters and setters
        public string Noise { get ; set ;}
        public string Color { get ; set ;}
        public int Age { get ; set ;}
        public int HP { get; set ;}

        // Empty constructor
        public Animal(){
        }

        // Constructor with 2 parameters
        public Animal(string noise, string color){
            Noise = noise;
            Color = color;
        }

        // Constructor with 3 parameters
        public Animal(string noise, string color, int age){
            Noise = noise;
            Color = color;
            Age = age;
        }

        // Methods for Animal
        public void SayNoise(){
            Console.WriteLine(this.Noise);
        }

        // Method for modifying HP
        public void TakeDamage(int damage){
            Console.WriteLine(this.HP);
            Console.WriteLine("Ouch! You took " + damage + " damage.");
            this.HP = this.HP - damage;
            Console.WriteLine(this.HP);
        }
    }
}
