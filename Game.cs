using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourHanoi
{
    class Game
    {
        private int moves;
        private int nDisc;
        private Peg[] pegs;

        public Game(int nDisc)
        {
            pegs = new Peg[3];
            pegs[0] = new Peg(nDisc, Map.PegLeft[0], Map.PegTop, Map.PegBot);
            pegs[1] = new Peg(nDisc, Map.PegLeft[1], Map.PegTop, Map.PegBot);
            pegs[2] = new Peg(nDisc, Map.PegLeft[2], Map.PegTop, Map.PegBot);

            for (int i = nDisc-1, index = 0; i >= 0; i--, index++)
            {
                pegs[0].Push(new Disc(i+1, Map.PegLeft[0], Map.PegBot - index, Map.DiskColors[i]));
            }

            Console.SetWindowSize(Map.MaxLeft, Map.MaxTop);

            this.nDisc = nDisc;
            moves = 0;
        }

        
        public void ComputerPlays(int discs, int src, int aux, int dst)
        {
            if(discs > 0)
            {
                ComputerPlays(discs - 1, src, dst, aux);
                Move(src, dst);
                ComputerPlays(discs - 1, aux, src, dst);
            }
        }

        
        public bool Move(int src, int dst)
        {
            try
            {
                moves++;

                if (src >= 0 && src <= 2 && dst >= 0 && dst <= 2 && pegs[src].DiscCount() > 0)
                {
                    if(pegs[dst].Push(pegs[src].Peek()))
                    {
                        pegs[dst].Peek().Move(Map.PegLeft[dst], Map.PegBot - pegs[dst].DiscCount()+1);

                        pegs[src].Pop();

                        return true;
                    }
                } 

                return false;
            }
            catch
            {
                return false;
            }            
        }

        
        public void Message(string msg)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(Map.MsgLeft, Map.MsgTop);

            Console.Write(msg);

            Console.ResetColor();
        }

        
        public void Draw()
        {
            Console.Clear();

            
            Console.SetCursorPosition(Map.BaseLeft, Map.BaseTop);
            for(int i = Map.BaseLeft; i <= Map.BaseRight; i++)
            {
                Console.Write("=");
            }

            
            for(int i = 0; i < pegs.Length; i++)
            {
                pegs[i].Draw();
            }
            
            
            Console.SetCursorPosition(Map.MovesLeft, Map.MovesTop);
            Console.Write("Déplacements: {0}", moves);
        }

        
        public bool Win()
        {
            return (pegs[2].DiscCount() == nDisc);
        }

        
        public void SrcPegPrompt()
        {
            Console.SetCursorPosition(Map.SrcLeft, Map.SrcTop);
            Console.Write("Src peg (1,2,3,q): ");
        }

        
        public void DstPegPrompt()
        {
            Console.SetCursorPosition(Map.DstLeft, Map.DstTop);
            Console.Write("Dst peg (1,2,3,q): ");
        }

    }
}
