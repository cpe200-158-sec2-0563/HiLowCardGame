using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HI_Low_Card_Game
{
    class Deck
    {
        int[] card;
        int index = 0;
        private Random rnd;
        int Number;
        public void Shuffle()
        {
            Random random = new Random();
            bool[] chek;
            chek = new bool[53];
            for (int i = 0; i < 52; i++)
            {
                chek[i] = false;
            }
            for (int i = 0; i < 52; i++)
            {
                 Number =  random.Next(52) + 1;
                while (chek[Number] == true)
                {
                    Number = random.Next(52) + 1;
                }
                card[i] = Number;
              //  while(card)

                chek[Number] = true;
            }
            index = 52;
        }
        public void show()
        {
            int i,p=0;
            i = index-1;
            while (card[i] > 13)
            {
                card[i] -= 13;
                p++;
            }
            if (card[i]>10)
             {
                 if (card[i] ==11)
                 {
                     Console.Write("J ");
                 }
                 else if (card[i] == 12)
                 {
                     Console.Write("Q ");
                 }
                 else if (card[i] == 13)
                 {
                     Console.Write("K ");
                 }
             }
             else
             {
                 if (card[i] == 1)
                 {
                     Console.Write("A ");
                 }
                 else
                 {
                     Console.Write(card[i]+" " );
                 }
             }
            if(p==0)
            {
                Console.WriteLine("Clubs");
            }
            else if(p==1)
            {
                Console.WriteLine("Diamonds");
            }
            else if(p==2)
            {
                Console.WriteLine("Hearts");
            }
            else if(p==3)
            {
                Console.WriteLine("Spades");
            }
           // Console.WriteLine(" ");;
        }
        public Deck ()
        {
            card = new int[52];
            for(int i =0;i<52;i++)
            {
                card[i] = i + 1;
                
            }

        }
         public int Draw ()
         {
            index--;
             return card[index];

         }
        public void AddCard(int n)
        {
            card[index] = n;
            index++;
        }
        public bool isEmpty ()
        {
            if (index == 0)
            {

                return true;
            }
            return false;
        }


    }
}
