using System;

public class PlayerCreator{

public string raceType;
public string yourGender;
public string name;
public int resolve;

public void whatGender(){
    Console.WriteLine("Please choose a gender");
    Console.WriteLine("Mr./Mrs.");
    yourGender = Console.ReadLine();
    }
    public void pickRace(){
    Console.WriteLine("What race would you like to be?");
    Console.WriteLine("Human, Elf, Orc, Dwarf");
    raceType = Console.ReadLine();
    
     switch(raceType) {
         case "Human":
         Console.WriteLine("What is Resolve?");
         Console.WriteLine("Health: " + (resolve + 10));
         break;

         case "Elf":
         Console.WriteLine("Class doesn't have a price.");
         Console.WriteLine("Health: " + (resolve + 90));
         break;

         case "Orc":
         Console.WriteLine("Shouldn't you wear a shirt?");
         Console.WriteLine("Health: " + (resolve + 100));
         break;

         case "Dwarf":
         Console.WriteLine("Small body, Big Heart.");
         Console.WriteLine("Health: " + (resolve + 50));
         break;

         default:
         Console.WriteLine("this is not a valid Race!");
         pickRace();
         break;

     }
    }
    public void whatsYourName(){
        Console.WriteLine("What is your Player name?");
        name = Console.ReadLine();
        Console.WriteLine("Welcome " + yourGender +" "+ name + " The " + raceType);
    }
}