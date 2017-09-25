using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGameLib
{
    public class DiceGame
    {
        Dice dice1;
        Dice dice2;
        public DiceGame(Random random)
        {
            dice1 = new Dice(random);
            dice2 = new Dice(random);
        }


        private int throws;
        private int totalDots;
        
        public void ThrowDices()
        {
            throws++;
            dice1.ThrowDice();
            dice2.ThrowDice();

            totalDots = dice1.CurrentNumberOfDots + dice2.CurrentNumberOfDots;
        }
        public void ThrowDices(int diceDotsForDiceOne, int diceDotsForDiceTwo)
        {
            throws++;
            dice1.ThrowDice(diceDotsForDiceOne);
            dice2.ThrowDice(diceDotsForDiceTwo);

            totalDots = dice1.CurrentNumberOfDots + dice2.CurrentNumberOfDots;
        }
        public string Feedback
        {
            get
            {                
                if(YouAreAWinner)
                return $"Well done you win, you got 7! You threw the dices and got {totalDots}! First dice got {dice1.CurrentNumberOfDots} and the second dice got {dice2.CurrentNumberOfDots} after {throws} tries.";
                else if(YouAreAWinner == false && throws > 0)
                    return $"You threw the dices and got {totalDots}! First dice got {dice1.CurrentNumberOfDots} and the second dice got {dice2.CurrentNumberOfDots} after {throws} tries.";
                else
                return "Throw the dices and try get 7";
            }
        }
        public bool YouAreAWinner
        {
           get {
                if(totalDots == 7)
                    return true;
                else
                return false;
            }
        }
        public int Throws
        {
            get { return throws; }
        }
    }
}
