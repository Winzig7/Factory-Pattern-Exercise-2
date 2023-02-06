﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() {Name = "Xbox", Price = 500 },
            new Product() {Name = "PS5", Price = 400 },
            new Product() {Name = "Switch", Price = 300 },
            new Product() {Name = "PC", Price = 1000 },
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from List Data Access.");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from List Data Access.");
        }
    }
}
