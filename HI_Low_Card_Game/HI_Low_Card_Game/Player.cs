using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HI_Low_Card_Game
{
    class Player
    {
        private Deck deck;
        private int score=0;
        public int sc ()
        {
            return score;
        }
        public Player()
        {
            deck = new Deck();
        }
        public void Draw()
        {
            deck.Draw();
        }
        public void Show ()
        {
            deck.show();
        }
          public int Addscore (int a)
           {
            return score+=a;
           }
         /*  public bool isPlay()
           {
               return 
           }
           public string Name
           {

           }*/
           public int Fight()
           {
            return deck.Draw();
           }
          /* public int FightAgain(int n)
           {
               return
           }*/
           public void AddCard (int n)
           {
            deck.AddCard(n);
           }
        public bool isEmpty()
        {
           return deck.isEmpty();
        }
    }
}
