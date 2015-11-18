using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HI_Low_Card_Game
{
    class Game
    {
        private Deck deck;
         private Player p1;
         private Player p2;
        int a1, a2,b1, b2,i;
        public void Play()
        {
            while (true)
            {
                if(p1.isEmpty())
                {
                    Console.WriteLine("END GAME ");
                    Console.WriteLine("Score player 1 : "+p1.sc());
                    Console.WriteLine("Score player 2 : "+p2.sc());
                    Console.ReadLine();
                }
                Console.Write("This is P1 : ");
                p1.Show();
                Console.Write("This is P2 : ");
                p2.Show();
                a1 = p1.Fight();
                a2 = p2.Fight();
                if (a1> a2)
                {
                    Console.WriteLine("P1 Win");
                    p1.Addscore(1);
                }
                else if (a1 < a2)
                {
                    Console.WriteLine("P2 Win");
                    p2.Addscore(1);
                }
                else if (a1 == a2)
                {
                    Console.WriteLine("Deal");
                    b1 = a1;
                    for( i=0;i< b1;i++)
                    {
                        if (p1.isEmpty())
                        {
                            break;
                        }
                        a1 = p1.Fight();
                       a2 = p2.Fight();
                       
                    }
                    int p=0;
                    Console.Write("Fight again This is P1 : ");
                    while (a1 > 13)
                    {
                        a1 -= 13;
                        p++;
                    }
                    if (a1 > 10)
                    {
                        if (a1 == 11)
                        {
                            Console.Write("J ");
                        }
                        else if (a1 == 12)
                        {
                            Console.Write("Q ");
                        }
                        else if (a1 == 13)
                        {
                            Console.Write("K ");
                        }
                    }
                    else
                    {
                        if (a1 == 1)
                        {
                            Console.Write("A ");
                        }
                        else
                        {
                            Console.Write(a1 + " ");
                        }
                    }
                    if (p == 0)
                    {
                        Console.WriteLine("Clubs");
                    }
                    else if (p == 1)
                    {
                        Console.WriteLine("Diamonds");
                    }
                    else if (p == 2)
                    {
                        Console.WriteLine("Hearts");
                    }
                    else if (p == 3)
                    {
                        Console.WriteLine("Spades");
                    }
                    Console.Write("fight again This is P2 : ");
                     p = 0;
                    while (a2 > 13)
                    {
                        a2 -= 13;
                        p++;
                    }
                    if (a2 > 10)
                    {
                        if (a2 == 11)
                        {
                            Console.Write("J ");
                        }
                        else if (a2 == 12)
                        {
                            Console.Write("Q ");
                        }
                        else if (a2 == 13)
                        {
                            Console.Write("K ");
                        }
                    }
                    else
                    {
                        if (a2 == 1)
                        {
                            Console.Write("A ");
                        }
                        else
                        {
                            Console.Write(a2 + " ");
                        }
                    }
                    if (p == 0)
                    {
                        Console.WriteLine("Clubs");
                    }
                    else if (p == 1)
                    {
                        Console.WriteLine("Diamonds");
                    }
                    else if (p == 2)
                    {
                        Console.WriteLine("Hearts");
                    }
                    else if (p == 3)
                    {
                        Console.WriteLine("Spades");
                    }
                    if (a1 > a2)
                    {
                        Console.WriteLine("P1 Win");
                        p1.Addscore(i+1) ;
                    }
                    else if (a1 < a2)
                    {
                        Console.WriteLine("P2 Win");
                        p2.Addscore(i+1);
                    }
                    else if (a1 == a2)
                    {
                        deck = new Deck();
                        deck.Shuffle();
                        //deck.show();
                        p1 = new Player();
                        p2 = new Player();
                        for (int i = 0; i < 26; i++)
                        {
                            p1.AddCard(deck.Draw());
                            p2.AddCard(deck.Draw());
                        }
                        Console.WriteLine("----New Game ----");
                        Play();
                    }
                }
           
                Console.ReadLine();
            }
        }
        public void Deal()
        {

        }
        public Game()
        {
            deck = new Deck();
            deck.Shuffle();
            //deck.show();
            p1 = new Player();
            p2 = new Player();
            for(int i = 0;i<26;i++)
            {
                p1.AddCard(deck.Draw()) ;
                p2.AddCard(deck.Draw()) ;
            }
         
            Play();
        }

    }
}
