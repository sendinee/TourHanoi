using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Input inp = new Input();

            
            int nDisc = inp.GetDiscCount();

            
            Game game = new Game(nDisc);
            
            
            game.Draw();

            do
            {
                
                game.SrcPegPrompt();
                int src = inp.GetPosition();
                if (src < 0)
                    break;

                game.DstPegPrompt();

                int dst = inp.GetPosition();
                if (dst < 0)
                    break;
                
                
                bool success = game.Move(src, dst);
                
                game.Draw();

                if (!success)
                {
                    game.Message("Déplacement non valide " + (src + 1) + " -> " + (dst + 1));
                }
            } while (!game.Win());

            game.Message("Appuyer sur entrée pour refaire!");

            Console.ReadLine();
        }
    }
}
