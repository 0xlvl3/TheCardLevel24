Console.Title = "The Card";

Card card = new Card();
//testing creating a new Card class instance within the variable firstCard
Card firstCard = new Card(CardColours.Red, CardRank.One);
Console.WriteLine($"{firstCard.cardColour} {firstCard.cardRank}");

//second testing creating a new Card class instance within the secondCard
Card secondCard = new Card(CardColours.Yellow, CardRank.Four);
Console.WriteLine($"{secondCard.cardRank} {secondCard.cardColour}");

//testing method
card.cardRank = RankIdenity();
Console.WriteLine($"{card.cardRank}");

//using the ColourIdentity method to see if user input matches correct value
card.cardColour = ColourIdentity();
Console.WriteLine($"{card.cardColour}");

//RankIdenity method, user input will determine output
CardRank RankIdenity()
{
    Console.Write($"Your card is :");
    int id = Convert.ToInt32(Console.ReadLine());
    return id switch
    {
        1 => CardRank.One,
        2 => CardRank.Two,
        3 => CardRank.Three,
        4 => CardRank.Four,
        5 => CardRank.Five,
        6 => CardRank.Six,
        7 => CardRank.Seven,
        8 => CardRank.Eight,
        9 => CardRank.Nine,
        10 => CardRank.Ten,
        11 => CardRank.DollarSign,
        12 => CardRank.PercentSign,
        13 => CardRank.UpArrow,
        14 => CardRank.And,
        _ => throw new NotImplementedException()

    };    
}

//CardIdentity method, user input will determine output
CardColours ColourIdentity()
{

    Console.Write($"Your card is :");
    int id = Convert.ToInt32(Console.ReadLine());
    return id switch
    {
        1 => CardColours.Red,
        2 => CardColours.Green,
        3 => CardColours.Blue,
        4 => CardColours.Yellow,
        _ => throw new NotImplementedException()
    };

}


//Our card class
public class Card
{
    //variables
    public CardColours cardColour { get; set; }
    public CardRank cardRank { get; set; }

    //constructor used to give us new card + rank
    public Card(CardColours colour, CardRank rank)
    {
        cardRank = rank;
        cardColour = colour;
    }

    //parameterless constructor
    public Card() { }

}


//enums
public enum CardColours { Red, Green, Blue, Yellow };
public enum CardRank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, PercentSign, UpArrow, And };
