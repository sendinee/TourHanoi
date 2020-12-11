using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourHanoi
{
    class Peg
    {
        private Disc[] discs;
        private int left;
        private int top;
        private int bot;
        private int index;
        private int size;
        
        
        public Peg(int maxDisc, int left, int top, int bot)
        {
            discs = new Disc[maxDisc];
            index = -1;
            this.left = left;
            this.top = top;
            this.bot = bot;
            size = maxDisc;
        }

        
        public bool Push(Disc dsc)
        {
            if (DiscCount() == 0 || dsc.Size < Peek().Size)
            {
                index++;
                discs[index] = dsc;

                return true;
            }
            else
            {
                return false;
            }
        }

        
        public Disc Pop()
        {
            if(size > 0)
            {
                Disc disc = discs[index];
                discs[index] = null;

                index--;

                return disc;
            }

            return null;
        }

        
        public Disc Peek()
        {
            if (index >= 0)
            {
                return discs[index];
            }

            return null;
        }

        
        public void Draw()
        {
            
            for (int row = 0; row < 8; row++)
            {
                Console.SetCursorPosition(left, top + row);
                Console.Write("{0}", "||");
            }

            
            for(int row = index; row >= 0; row--)
            {
                discs[row].Draw();
            }
        }

        
        public int DiscCount()
        {
            return index+1;
        }
    }
}
