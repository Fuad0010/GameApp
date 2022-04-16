using Business.Services;
using Entities.Models;
using System;
using Utilities.Helper;

namespace GameApp
{
    class Program
    {
        private static GameService gameService;
        public Program()
        {
            gameService = new GameService();
        }


        static void Main(string[] args)
        {

            byte key;
            do
            {

                Extention.Print(ConsoleColor.Magenta, "= = = = Welcome = = = =");
                Extention.Print(ConsoleColor.Cyan, "1. Add Game.\n" +
                                                   "2. Buy Game.\n" +
                                                   "3. Update Game.");

                key = Convert.ToByte(Console.ReadLine());
            } while (!(key == 1 || key == 2));

            switch (key)
            {
                case 1:
                    Extention.Print(ConsoleColor.Magenta, "Please enter a name game.");
                    string name = Console.ReadLine();
            
                    Game game = new Game();
                    game.Name = name;

                    gameService.Create(game);       // yazdigimizi game name i game name e add edir
                    do
                    {
                        Extention.Print(ConsoleColor.Magenta, $"What format will {game.Name} be in?");
                        Extention.Print(ConsoleColor.Cyan, $"1. 2D\n" +
                                                           $"2. 3D");
                        key = Convert.ToByte(Console.ReadLine());

                    }while (!(key == 1 || key == 2));
                        switch (key)
                    {
                        case 1:

                            break;

                        case 2:

                        break;
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;

            }






        }
    }
}
