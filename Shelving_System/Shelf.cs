﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShelvingSystem
{
    class Shelf
    {
        Product[,] shelfStorage;
        private int height, lenght;        
        public Shelf (int height, int lenght)
        {
            this.height = height;
            this.lenght = lenght;
            shelfStorage = new Product[height, lenght];
        }

        public void Show()
        {          
            for (int i = 0; i < shelfStorage.GetLength(0); i++)
            {
                Console.Write("\n");
                Console.WriteLine("---------------------");
                for (int j = 0; j < shelfStorage.GetLength(1); j++)
                {
                    Console.Write("|");
                    try
                    {
                        Console.Write($"{shelfStorage[i, j].ShortSign}");                        
                    }
                    catch (Exception)
                    {
                        Console.Write(" ");
                    }                    
                }
                Console.Write("|");
            }            
            Console.Write("\n");
            Console.Write("---------------------");
        }

        public double Workload()
        {
            double workload = 0;
            double storage = height * lenght;
            double occupied = 0;
            
            
            for (int i = 0; i < shelfStorage.GetLength(0); i++)
            {
                for (int j = 0; j < shelfStorage.GetLength(1); j++)
                {
                    try
                    {
                        if (!shelfStorage[i, j].Equals(null))
                        {
                            occupied++;
                        }
                    }
                    catch (Exception)
                    {
                        
                    }            
                }
            }
            
            workload = 100 * occupied / storage;            
            return workload;
        }

        public void Store(Product product)
        {
            for (int i = 0; i < shelfStorage.GetLength(0); i++)
            {
                for (int j = 0; j < shelfStorage.GetLength(1); j++)
                {
                    if(shelfStorage[i, j].Equals(null))
                    {
                        shelfStorage[height, lenght] = product;
                    }
                }
            }
        }

        public Boolean Store(int height, int lenght, Product product)
        {
            bool stored = false;
            try
            {
                if (!shelfStorage[height, lenght].Equals(null))
                {
                    Console.WriteLine($"Field {height}/{lenght} is occupied --> {shelfStorage[height, lenght].Description}");
                }
            }
            catch (NullReferenceException)
            {
                shelfStorage[height, lenght] = product;
                stored = true;
            }           
            
            return stored;
        }        
        
    }
}
