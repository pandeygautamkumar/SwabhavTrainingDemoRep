﻿using MovieBusinessLayerLib.Model;
using System;

namespace MovieConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieStore movieStore1 = new MovieStore();
            while (true)
            {
                DisplayMenu(movieStore1);
                TakeUserChoice(movieStore1);
            }
        }
        private static void DisplayMenu(MovieStore movieStore)
        {
            Console.WriteLine($"Welcome to Movie Store App. Available Movies are : {movieStore.NoOfMovies}");
            Console.WriteLine("(1).Add      (2).Display       (3).Exit");
        }
        private static void TakeUserChoice(MovieStore movieStore)
        {
            Console.Write("Enter Our Choice : ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    string movieName;
                    int releasedYear;
                    TakeMovieDetails(out movieName, out releasedYear);
                    movieStore.AddMovie(new Movie(movieName, releasedYear));
                    break;
                case 2:
                    movieStore.GetMovies();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("You entered Wrong Choice.");
                    break;
            }
            Console.WriteLine();
        }
        private static void TakeMovieDetails(out string movieName, out int releasedYear)
        {
            Console.Write("Enter Movie Name: ");
            movieName = Console.ReadLine();
            Console.Write("Enter Released Year : ");
            releasedYear = int.Parse(Console.ReadLine());
        }
    }
}