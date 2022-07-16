using System;
using System.IO;
using Newtonsoft.Json;

namespace JsonSuperHero
{
    public class Human
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int age;
        public string nationality { get; set; } 
    }
   
    public class SuperHero : Human
    {      
        public bool warrior { get; set; }
        public string[] Abilities { get; internal set; }
        public Ability superpower = new Ability();
    }
   
    public class Ability
    {        
        public bool isUnique;
        public string[] abilities;
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            SuperHero superhero1 = new SuperHero
            {
                Name = "Роман Грибов",
                age = 32,
                nationality = "українець",
                Abilities = new[] { "Захист морського кордону", "Надіслати російський корабель", "Залишитись живим" },
                warrior = true
            };

            SuperHero superhero2 = new SuperHero
            {
                Name = "Денис Прокопенко",
                age = 31,
                nationality = "українець",
                Abilities = new[] { "Захист Азовсталї", "Незламність", "Мужність" },
                warrior = true
            };

            string json1 = JsonConvert.SerializeObject(superhero1, Formatting.Indented);
            string json2 = JsonConvert.SerializeObject(superhero2, Formatting.Indented);
            Console.WriteLine(json1);
            Console.WriteLine(json2);

            string path = @"C:\1\json.json";
            File.WriteAllText(path, json1 + json2);           
        }       
    }
}