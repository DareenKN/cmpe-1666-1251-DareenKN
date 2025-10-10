/* CMPE1600 - Intermediate Programming
 * Name: Dareen Kinga Njatou
 * 
 * Description: CMPE 1666-ICA06- Fisher-Yates Shuffling Algorithm 
 *               use the fisher Yates algorithm to shuffle a deck 
 *               of 52 cards, deal a hand to each of 10 players 
 *               and find a winner. 
 * 
 * Date: October 7, 2025
 */
using System;
using System.Windows.Forms;

namespace ICA6_DareenKN
{
    public partial class Form1 : Form
    {
        // Struct to store attributes for a card
        private struct Card
        {
            public Suit _suit;      // Suit type of the card
            public int _rank;       // Rank number of the card
            public int _points;     // Point value of the card
            public string _symbol;  // Symbol to represent the card
        }

        // Enum Type for Suit
        public enum Suit
        {
            Hearts,     // 4
            Diamonds,   // 3
            Club,       // 2
            Spade       // 1
        }

        // Card deck as an array
        private Card[] deck = new Card[52];

        // Card deck as a 2D array
        private Card[,] playerHands = new Card[10, 5];

        int[] playerPoints = new int[10];   // Stores total point of each player

        int[] shuffleCardIndex = new int[52]; // Compact for for the deck, makes easy 
                                              // to shuffle by just targetting the indexes

        private Random rand = new Random(); // Random number generator



        public Form1()
        {
            InitializeComponent();

            int index = 0;  // Index of the cards

            // Initializing the deck to be used
            for (int suitType = 0; suitType < 4; suitType++)
            {
                for (int rankNum = 2; rankNum <= 14; rankNum++)                
                    deck[index++] = CreateCard((Suit)suitType, rankNum);                
            }

            // Initializing a parallel array which only stores indexes
            for (int i = 0; i < shuffleCardIndex.Length; i++)
                shuffleCardIndex[i] = i;
            
        }

        /// <summary>
        /// Initializes a card with its attributes
        /// </summary>
        /// <param name="suit"></param>
        /// <param name="rank"></param>
        /// <returns></returns>
        private Card CreateCard (Suit suit, int rank)
        {
            Card card = new Card(); // Creating a new card
            card._suit = suit;      // Stores the suit type of the card
            card._rank = rank;      // Stores the rank number of the card

            int weight = 0;     // Value of a card from a particular suit

            // Assigning weight values to each suit
            switch (suit)
            {
                case Suit.Hearts:   weight = 4; break;
                case Suit.Diamonds: weight = 3; break;
                case Suit.Club:     weight = 2; break;
                case Suit.Spade:    weight = 1; break;
            }

            // Calculating point for each card
            card._points = rank * weight;

            // Assigning symbols to cards 
            if (rank >= 2 && rank <= 10)
                card._symbol = $"{rank}";
            else
            {
                switch (rank)
                {
                    case 11: card._symbol = "J"; break;
                    case 12: card._symbol = "Q"; break;
                    case 13: card._symbol = "K"; break;
                    case 14: card._symbol = "A"; break;
                }
            }
            return card;
        }

        /// <summary>
        /// Returns a string representation of a card
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        private string CardToString(Card card)
        {
            return $"Card: {card._suit} {card._symbol} \tPoints: {card._points}";
        }

        /// <summary>
        /// Implements the Fisher-Yates shuffle algorithm
        /// </summary>
        /// <param name="deckIndex"></param>
        private void ShuffleCards(int[] deckIndex)
        {
            for(int i = 52 - 1; i > 0; i--)
            {
                int j = rand.Next(0, i + 1);
                int temp = deckIndex[i];
                deckIndex[i] = deckIndex[j];
                deckIndex[j] = temp;
            }
        }

        /// <summary>
        /// It deals 5 cards to each of the 10 players
        /// </summary>
        /// <param name="deckIndex"></param>
        /// <param name="playerHands"></param>
        private void DealHands(int[] deckIndex, Card[,] playerHands)
        {
            // Clear any existing hands/points
            Array.Clear(playerPoints, 0, playerPoints.Length);

            //
            int cardIndex = 0;
            for (int round = 0; round < 5; round++) 
            {
                for (int player = 0; player < 10; player++)
                {
                    int deckPosn = deckIndex[cardIndex++];
                    playerHands[player, round] = deck[deckPosn];
                    playerPoints[player] += playerHands[player, round]._points;
                }
            }
        }

        /// <summary>
        /// It determines the winner based on the highest points
        /// </summary>
        /// <param name="playerPointsArray"></param>
        /// <returns></returns>
        private int DetermineWinner(int[] playerPointsArray)
        {
            int maxPoints = -1;     // Starts at -1m meaning no winners yet
            int winnerIndex = -1;   // Arrays stars from zero

            // Looping through the player points array to find the max points
            for (int i = 0; i < playerPointsArray.Length; i++)
            {
                if(playerPointsArray[i] > maxPoints)
                {
                    maxPoints = playerPointsArray[i];
                    winnerIndex = i;
                }
            }
            return winnerIndex;
        }

        /// <summary>
        /// It loads the initial deck of cards into the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_LoadCards_Btn_Click(object sender, EventArgs e)
        {
            // Clear any existing items
            UI_StartingDeck_Lbx.Items.Clear();

            // Display initial deck of cards
            for (int i = 0; i < deck.Length; i++)
                UI_StartingDeck_Lbx.Items.Add(CardToString(deck[i]));
        }

        /// <summary>
        /// It shuffles the deck of cards and displays them in the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_ShuffleCards_Btn_Click(object sender, EventArgs e)
        {
            // Reset shuffledeck to initial deck
            for (int i = 0; i < 52; i++)
                shuffleCardIndex[i] = i;

            // Shuffling deck indices
            ShuffleCards(shuffleCardIndex);

            // Clear any existing items
            UI_ShuffledDeck_Lbx.Items.Clear();

            // Display shuffled cards
            for (int i = 0; i < 52; i++)
                UI_ShuffledDeck_Lbx.Items.Add(CardToString(deck[shuffleCardIndex[i]]));
        }

        /// <summary>
        /// It deals 5 cards to each of the 10 players
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_DealHands_Btn_Click(object sender, EventArgs e)
        {
            // Clear any existing items
            UI_PlayersHands_Lbx.Items.Clear();

            // Using the shuffleIndex array to ensure that there is a shuffled deck
            DealHands(shuffleCardIndex, playerHands);

            // Display each player's hand and total
            for (int player = 0; player < 10; player++)
            {
                UI_PlayersHands_Lbx.Items.Add($"Player {player + 1}");
                UI_PlayersHands_Lbx.Items.Add("-------------------");
                int totalPoints = 0;
                for (int count = 0; count < 5; count++)
                {
                    UI_PlayersHands_Lbx.Items.Add(CardToString(playerHands[player, count]));
                    totalPoints += playerHands[player, count]._points;
                }
                UI_PlayersHands_Lbx.Items.Add($"Total: {totalPoints}\n");
                UI_PlayersHands_Lbx.Items.Add("");
            }
        }

        /// <summary>
        /// It determines the winner among the 10 players
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_DetermineWinner_Btn_Click(object sender, EventArgs e)
        {
            // Clear any existing value in the textbox
            UI_Winner_Tbx.Clear();

            // Determine the winner
            int winner = DetermineWinner(playerPoints);

            // Display the winner based on total points ELSE no winners
            if (winner >= 0)
                UI_Winner_Tbx.Text = $"Player {winner + 1}- Points: {playerPoints[winner]}";
            else
                UI_Winner_Tbx.Text = "No winners determined";
        }
    }
}
