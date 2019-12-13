using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtZavod
{
    class Menu: Program
    {
        public static  void MainMenu() 
        {
            var commands = new Dictionary<ConsoleKey, IDetal>
            {
                [ConsoleKey.Spacebar] = new GetRandom(),
                [ConsoleKey.Tab] = new Status(),
            };

            var menu = true;
            while (menu)
            {
                var key = Console.ReadKey().Key;
                if (!commands.ContainsKey(key))
                    break;

                var selectedCommand = commands[key];
                selectedCommand.Made();
            }
        }
    }
}
