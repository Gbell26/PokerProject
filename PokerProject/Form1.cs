using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DeckofCard gameDeck = new DeckofCard();

        Card[] yourHand = new Card[5];
        Card[] theirHand = new Card[5];

        private void ShuffleButton_Click(object sender, EventArgs e)
        {
            gameDeck.Shuffle();
        }

        private void DealButton_Click(object sender, EventArgs e)
        {

            //Deals cards to each hand your hand first then theirs. Validates there are still cards
            //in the deck before dealing each card

            {
                if (gameDeck.currentCard < 52)
                {
                    yourHand[0] = gameDeck.DealCard();
                    yourHandCard1.Text = yourHand[0].ToString();

                }
                else
                {
                    MessageBox.Show("Shuffling Deck", "Shuffle");
                    gameDeck.Shuffle();
                }

                if (gameDeck.currentCard < 52)
                {
                    theirHand[0] = gameDeck.DealCard();
                    theirCard1lbl.Text = theirHand[0].ToString();
                }
                else
                {
                    MessageBox.Show("Shuffling Deck", "Shuffle");
                    gameDeck.Shuffle();
                }
                if (gameDeck.currentCard < 52)
                {
                    yourHand[1] = gameDeck.DealCard();
                    yourHandCard2.Text = yourHand[1].ToString();
                }
                else
                {
                    MessageBox.Show("Shuffling Deck", "Shuffle");
                    gameDeck.Shuffle();
                }
                if (gameDeck.currentCard < 52)
                {
                    theirHand[1] = gameDeck.DealCard();
                    theirCard2lbl.Text = theirHand[1].ToString();
                }
                else
                {
                    MessageBox.Show("Shufflling Deck", "Shuffle");
                    gameDeck.Shuffle();
                }
                if (gameDeck.currentCard < 52)
                {
                    yourHand[2] = gameDeck.DealCard();
                    yourHandCard3.Text = yourHand[2].ToString();
                }
                else
                {
                    MessageBox.Show("Shuffling Deck", "Shuffle");
                    gameDeck.Shuffle();
                }
                if (gameDeck.currentCard < 52)
                {
                    theirHand[2] = gameDeck.DealCard();
                    theirCard3lbl.Text = theirHand[2].ToString();
                }
                else
                {
                    MessageBox.Show("Shuffling Deck", "Shuffle");
                    gameDeck.Shuffle();
                }
                if (gameDeck.currentCard < 52)
                {
                    yourHand[3] = gameDeck.DealCard();
                    yourCardHand4.Text = yourHand[3].ToString();
                }
                else
                {
                    MessageBox.Show("Shuffling Deck", "Shuffle");
                    gameDeck.Shuffle();
                }
                if (gameDeck.currentCard < 52)
                {
                    theirHand[3] = gameDeck.DealCard();
                    theirCard4lbl.Text = theirHand[3].ToString();
                }
                else
                {
                    MessageBox.Show("Shuffling Deck", "Shuffle");
                    gameDeck.Shuffle();
                }
                if (gameDeck.currentCard < 52)
                {
                    yourHand[4] = gameDeck.DealCard();
                    yourHandCard5.Text = yourHand[4].ToString();
                }
                else
                {
                    MessageBox.Show("Shuffling Deck", "Shuffle");
                    gameDeck.Shuffle();
                }
                if (gameDeck.currentCard < 52)
                {
                    theirHand[4] = gameDeck.DealCard();
                    theirCard5lbl.Text = theirHand[4].ToString();
                }
                else
                {
                    MessageBox.Show("Shuffling Deck", "Shuffle");
                    gameDeck.Shuffle();
                }
            }
        }//End of Deal Method

        private void btnShowHand_Click(object sender, EventArgs e)
        {
            //Determin win conditions.
            //Compare card faces/suits to determine pairs etc.
            //assign int hand value based on cards in hand

            int yourHandScore;
            int theirHandScore;

            int numOfAce = 0;
            int numOfTwo = 0;
            int numOfThree = 0;
            int numOfFour = 0;
            int numOfFive = 0;
            int numOfSix = 0;
            int numOfSeven = 0;
            int numOfEight = 0;
            int numOfNine = 0;
            int numOfTen = 0;
            int numOfJack = 0;
            int numOfQueen = 0;
            int numOfKing = 0;

            bool twoKind = false;
            bool threeKind = false;
            bool fourKind = false;

            for (int i = 0; i < yourHand.Length; i+=1)
            {
                switch (yourHand[i].Face)
                {
                    case "Ace":
                        numOfAce+=1;
                        break;
                    case "Duece":
                        numOfTwo += 1;
                        break;
                    case "Three":
                        numOfThree += 1;
                        break;
                    case "Four":
                        numOfFour += 1;
                        break;
                    case "Five":
                        numOfFive += 1;
                        break;
                    case "Six":
                        numOfSix += 1;
                        break;
                    case "Seven":
                        numOfSeven += 1;
                        break;
                    case "Eight":
                        numOfEight += 1;
                        break;
                    case "Nine":
                        numOfNine += 1;
                        break;
                    case "Ten":
                        numOfTen += 1;
                        break;
                    case "Jack":
                        numOfJack += 1;
                        break;
                    case "Queen":
                        numOfQueen += 1;
                        break;
                    case "King":
                        numOfKing += 1;
                        break;
                }
            }
            MessageBox.Show($"{numOfAce.ToString()}{numOfTwo.ToString()}{numOfThree.ToString()}{numOfFour.ToString()}" +
                $"{numOfFive.ToString()}{numOfSix.ToString()}{numOfSeven.ToString()}{numOfEight.ToString()}{numOfNine.ToString()}" +
                $"{numOfTen.ToString()}{numOfJack.ToString()}{numOfQueen.ToString()}{numOfKing.ToString()}");
            if (numOfAce == 2|| numOfTwo == 1 || numOfThree == 2||numOfFour == 2 || numOfFive == 2||
                numOfSix == 2 || numOfSeven == 2|| numOfEight == 2|| numOfNine == 2 || numOfTen ==2 ||
                numOfJack == 2 || numOfQueen == 2 || numOfKing == 2)
            {
                twoKind = true;
            }
            if (numOfAce == 3 || numOfTwo == 3 || numOfThree == 3 || numOfFour == 3 || numOfFive == 3 ||
                numOfSix == 3 || numOfSeven == 3 || numOfEight == 3 || numOfNine == 3 || numOfTen == 3 ||
                numOfJack == 3 || numOfQueen == 3 || numOfKing == 3)
            {

                threeKind = true;
                
            }
            if(numOfAce == 4 || numOfTwo == 4 || numOfThree == 4 || numOfFour == 4 || numOfFive == 4 ||
                numOfSix == 4 || numOfSeven == 4 || numOfEight == 4 || numOfNine == 4 || numOfTen == 4 ||
                numOfJack == 4 || numOfQueen == 4 || numOfKing == 4)
            {
                fourKind = true;
                
            }

            if (twoKind == true)
            {
                MessageBox.Show("You have a pair");
            }
            if (threeKind == true)
            {
                MessageBox.Show("You have three of a kind");
            }
            if (fourKind == true )
            {
                MessageBox.Show("You have four of a kind");
            }

        }
    }
}
