using System;
using System.Collections.Generic;
using System.Text;

namespace Ovoshi
{
    class Bulba : Vegetable
    {
        public static int Calories { get; private set; } = 20;
        public static int Weight { get; private set; } = 30;
        public static string Color { get; private set; } = "Yellow";
        public static string Name { get; private set; } = "Kartoshka";
    }
    class Onion: Vegetable
    {
        public static int Calories { get; private set; } = 25;
        public static int Weight { get; private set; } = 34;
        public static string Color { get; private set; } = "White";
        public static string Name { get; private set; } = "Luchok";
    }
    class Bellpepper : Vegetable
    {
        public static int Calories { get; private set; } = 45;
        public static int Weight { get; private set; } = 54;
        public static string Color { get; private set; } = "Red";
        public static string Name { get; private set; } = "Perchik";
    }
    class Tomato : Vegetable
    {
        public static int Calories { get; private set; } = 33;
        public static int Weight { get; private set; } = 125;
        public static string Color { get; private set; } = "Red";
        public static string Name { get; private set; } = "Pomidorka";
    }
    class Carrot : Vegetable
    {
        public static int Calories { get; private set; } = 21;
        public static int Weight { get; private set; } = 99;
        public static string Color { get; private set; } = "Orange";
        public static string Name { get; private set; } = "Morkovochka";
    }
    class Cabbage : Vegetable
    {
        public static int Calories { get; private set; } = 23;
        public static int Weight { get; private set; } = 77;
        public static string Color { get; private set; } = "Green";
        public static string Name { get; private set; } = "Kapustochka";
    }
    class Pea : Vegetable
    {
        public static int Calories { get; private set; } = 5;
        public static int Weight { get; private set; } = 6;
        public static string Color { get; private set; } = "Green";
        public static string Name { get; private set; } = "Goroshek";
    }
    class Aubergine : Vegetable
    {
        public static int Calories { get; private set; } = 88;
        public static int Weight { get; private set; } = 99;
        public static string Color { get; private set; } = "Purple";
        public static string Name { get; private set; } = "Baklazhanchik";
    }
}
