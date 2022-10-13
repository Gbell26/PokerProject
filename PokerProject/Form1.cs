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

            
        }
    }
}
