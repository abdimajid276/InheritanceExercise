using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var birdOne = new Bird();
            birdOne.name = "Eagle";
            birdOne.age = 4;
            birdOne.Diet = "insects";
            birdOne.CanFly = true;
            birdOne.IsAlive = true;
            
            Console.WriteLine($"name: {birdOne.name}/nAge: {birdOne.age}/nDiet: {birdOne.Diet}/nCanFly: {birdOne.CanFly}/nIsAlive: {birdOne.IsAlive}");


            var reptileOne = new Reptile();
            reptileOne.name = "viper";
            reptileOne.age = 5;
            reptileOne.IsAlive = true;
            reptileOne.IsPoisonous = true;
            reptileOne.ForkTongue = true;
            reptileOne.ScaleColor = "Black";

                Console.WriteLine($"name: {reptileOne.name}/nAge: {reptileOne.age}/nIsAlive: {reptileOne.IsAlive}/nIsPoisonous: {reptileOne.IsPoisonous}/nForkTongue: {reptileOne.ForkTongue}/nScaleColor: {reptileOne.ScaleColor}");



        }
    }
}
