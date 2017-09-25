using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberLib
{
    public class GuessNumber
    {
        private int numberToGuess;
        private int lastguess;
        
        private int triesMade;

        private bool gameOver = false;
        public GuessNumber()
        {
            Random random = new Random();
            this.numberToGuess = random.Next(1, 100);
        }
        public void newGame()
        {
            triesMade = 0;
            Random random = new Random();
            this.numberToGuess = random.Next(1, 100);
            gameOver = false;
        }
        public GuessNumber(int numberToGuess)
        {
            Random random = new Random();
            this.numberToGuess = numberToGuess;
        }
        public string Feedback
        {
            get
            {
                if (triesMade == 0)
                    return "Guess a number between 1 and 100.";
                else if (lastguess < numberToGuess)
                    return "Guess higher.";
                else if (lastguess > numberToGuess)
                    return "Guess lower.";
                else
                {
                    this.gameOver = true;
                    return $"You made it in {triesMade} tries.";
                }
            }
        }

        public int Tries
        {
            get
            {
                return triesMade;
            }
        }
        public bool GameOver
        {
            get
            {
                return gameOver;
            }
        }

        public void Guess(int guessedNumber)
        {
            lastguess = guessedNumber;
            triesMade++;
        }
    }
}