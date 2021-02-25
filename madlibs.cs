using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program  we’ll use C# to write a Mad Libs word game! Mad Libs are short stories with blanks for the player to fill in that represent different parts of speech. The end result is a really hilarious and strange story. 
      Author: Camis Monteiro by Codecademy
      */


      // Let the user know that the program is starting:
  Console.WriteLine("Mad Libs START!");

      // Give the Mad Lib a title:
    //  string title = "titulo";

    //  Console.WriteLine(title);
      // Define user input and variables:
         Console.Write("Qual seu nome?");
    string name = Console.ReadLine();

        Console.Write("Insira 3 adjetivos: ");
    string adjective1 = Console.ReadLine();
    string adjective2 = Console.ReadLine();
    string adjective3 = Console.ReadLine();



      Console.Write("Insira  um verbo ");
    string verb = Console.ReadLine();
 
    


      Console.Write("Insira 2 substantivos.");
    string noun1 = Console.ReadLine();
    string noun2 = Console.ReadLine();



  Console.WriteLine("Insira um animal: ");
    string animal = Console.ReadLine();

  Console.WriteLine("Insira um comida: ");
    string food =  Console.ReadLine();

  Console.WriteLine("Insira um fruta: ");
     string fruit = Console.ReadLine();

  Console.WriteLine("Insira um superheroi: ");
     string superhero =  Console.ReadLine();

  Console.WriteLine("Insira um país: ");
  string country =   Console.ReadLine();

  Console.WriteLine("Insira um sobremesa: ");
   string dessert = Console.ReadLine();

  Console.WriteLine("Insira um ano: ");
     string year = Console.ReadLine();

      //The template for the story:

     string story = $" Essa manhã {name} acordoi se sentindo {adjective1} .' Vai ser um dia de {adjective2} day!' Lá fora, um bando de {animal}s
gritavam para manter {food} nas lojas. Eles começaram a {verb}   ao ritmo do {noun1}, o que tornava todas as {fruit}s    muito {adjective3}.  
 Preocupado,  {name}    mandou uma mensagem para {superhero},    que voou {name}     para {country} e jogou {name} uma poça de  {dessert}. congelada
      {name} acordou no ano  {year},       em um mundo onde  {noun2}s governava o mundo.";


      // Print the story: 
      
  Console.WriteLine(story);
    }
  }
}
