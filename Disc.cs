using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourHanoi
{
    class Disc
    {
        private int size;
        private int left;
        private int top;
        private ConsoleColor color;

        
        public Disc(int size, int left, int top, ConsoleColor color)
        {
            this.size = size;
            this.left = left;
            this.top = top;
            this.color = color;
        }

        
        public int Size
        {
            get
            {
                return size;
            }
        }

        
        public void Draw()
        {
            Console.BackgroundColor = color;
            Console.SetCursorPosition(left - size*2 + 1, top);
            
            for (int s = 0; s < size * 4; s++)
            {
                Console.Write(" ");
            }            

            Console.SetCursorPosition(left, top);
            Console.Write("||");

            Console.ResetColor();
        }

        
        public void Move(int left, int top)
        {
            this.left = left;
            this.top = top;
        }

    }
}
