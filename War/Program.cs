using War.Models;


var Deck = new Deck();
Deck.Shuffle();
var totalTurns = 0;
var Player1 = new Player("Player1");
var Player2 = new Player("Player2");

Player1.Cards = Deck.Cards.Take(26).ToList();
Player2.Cards = Deck.Cards.Skip(26).ToList();

//declare a function
void HandleWar(int index)
{

    var warCard1 = Player1.Cards.Count > index ? Player1.Cards[index] : Player1.Cards.Last();
    var warCard2 = Player2.Cards.Count > index ? Player2.Cards[index] : Player2.Cards.Last();



    if (warCard1.Value > warCard2.Value)
    {
        Player1.DiscardCards.Add(warCard2);
        Player2.Cards.RemoveAt(0);
    }
    else if (warCard1.Value < warCard2.Value)
    {
        Player2.DiscardCards.Add(warCard1);
        Player1.Cards.RemoveAt(0);
    }
    else
    {
        HandleWar(index + 4);
    }
} 

//compare card
while (Player1.Cards.Count != 0 && Player2.Cards.Count != 0)
{

    if(Player1.Cards.Count == 0 && Player1.DiscardCards.Count > 0)
    {
        Player1.Cardd.Add
        Player1.Shuffle();
    }

    if (Player2.Cards.Count == 0 && Player2.DiscardCards.Count > 0)
    {
        Player2.Cards = Player2.DiscardCards;
        Player2.Shuffle();
    }

    var card1 = Player1.Cards.First();
    var card2 = Player2.Cards.First();

    if (card1.Value > card2.Value)
    {
        Player1.DiscardCards.Add(card2);
        Player2.Cards.RemoveAt(0);

    }
    else if (card1.Value < card2.Value)
    {
        Player2.DiscardCards.Add(card1);
        Player1.Cards.RemoveAt(0);
    }
    else
    {
        HandleWar(4);
    }
    totalTurns++;
}

Console.WriteLine($"Total turns: {totalTurns}");
Console.WriteLine(Player1.Cards.Count > 0 ? "Player 1 Wins" : "Player 2 Wins");
