﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle viereck = new Rectangle();
            
            GraphicCircle gCircle = new GraphicCircle();
            Console.WriteLine($"Anzahl der Objekte ist: {GeometricObject.CountGeometricObjects}");
            
            Circle kreis = new Circle();
            Circle kreis1 = new Circle();
            kreis1.Radius = 22;
            Circle kreis2 = new Circle();
            kreis2.Radius = 23;
           
            if (kreis1.Bigger(kreis2) == -1)
                Console.WriteLine("kreis1 < kreis 2");
            Console.ReadLine();

            kreis.XCoordinate = -100;
            kreis.YCoordinate = 90;
            kreis.Move(120, -200);

           

            Console.WriteLine("Geben sie den Radius an");
            kreis.Radius = Convert.ToDouble(Console.ReadLine());

            
            

            Console.WriteLine($"Die Fläche beträgt {kreis.GetArea()}" );
            Console.WriteLine($"Der Umfang beträgt {kreis.GetPerimeter()}");

            Console.ReadLine();

            Console.WriteLine($"Geben sie die Länge des Vierecks an");
            viereck.Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Geben sie die Breite des Vierecks an");
            viereck.With = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Der Umfang beträgt: {viereck.GetPerimeter()}");
            Console.WriteLine($"Die Fläche beträgt: {viereck.GetArea()}");

            Console.ReadLine();

            if (kreis != null)
            {
                Console.WriteLine("Das Objekt existiert nicht");
                kreis = new Circle();
            }
            else
            {
                Console.WriteLine("Das Objekt existiert");
                Console.ReadLine();
            }
        }
    }
}