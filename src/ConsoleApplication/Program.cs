﻿//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            /*
            for(int i = 1; i <= 100; i++)
            {
                var train = new Train("trenes");
                train.StartEngines();
                Console.WriteLine($"La cantidad de objetos creados son: {Train.count}");
            }
            */
            //Console.WriteLine("Hello World!");

            Train t1 = new Train("Last Train To London");
            Train t2 = new Train("Last Train To London");
            Train t3 = new Train("Runaway Train");
            
            Console.WriteLine(t1 == t2); // Es falso
            Console.WriteLine(t2 == t3); // Es falso

        }
    }
}