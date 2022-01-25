using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.App
{
    internal static class Program
    {
        private static void Main()
        {

            using (ContextApp _db = new ContextApp())
            {
                Game game1 = new Game { Name = "Lego Movie", Creator = "TT Fusion", Style = "Adventure", Date = 2014 };
                Game game2 = new Game { Name = "Angry Birds", Creator = "Rovio", Style = "Arcade", Date = 2004 };

                _db.Games.Add(game1);
                _db.Games.Add(game2);
                _db.SaveChanges();
                Console.WriteLine("Объекты добавлены!");

                var games = _db.Games.ToList();
                Console.WriteLine("Список объектов: ");
                foreach (Game g in games)
                {
                    Console.WriteLine($"{g.Name}, {g.Creator}, {g.Style}, {g.Date}");
                }
            }

        }

    }
}

