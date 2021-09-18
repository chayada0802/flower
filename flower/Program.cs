using System;
using System.Collections.Generic;

namespace flower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Total Rose :");
            int roseid = int.Parse(Console.ReadLine());
            Console.Write("Input Total Sun Flower:");
            int sunid = int.Parse(Console.ReadLine());
             
        }

       
    }
  
         public class Flower
        {
        List<Flower> flowers= new List<Flower>();
           public int ID;
           public string Plantname;
           public string Plantdescription;
           public int Amount;
           public string Height;
           public string Circumferance;
        public Flower(int iD, string plantname, string plantdescription, int amount, string height, string circumferance)
        {
            this.ID = iD;
            this.Plantname=plantname;
            this.Plantdescription = plantdescription;
            this.Amount = amount;
            this.Height = height;
            this.Circumferance = circumferance;

        }

         
    }

    class rosein : Flower
    {
        public rosein(int iD, string plantname, string plantdescription, int amount, string height, string circumferance) : base(iD, plantname, plantdescription, amount, height, circumferance)
        {
            Console.WriteLine("Rose name"+plantname);
        }
    }

    class sunin : Flower
    {
        public sunin(int iD, string plantname, string plantdescription, int amount, string height, string circumferance) : base(iD, plantname, plantdescription, amount, height, circumferance)
        {
            Console.WriteLine("Sun Flowers name" + plantname);
        }
    }
}
