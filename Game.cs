namespace cousinzins2023
{
    public class Card
    {
        public string image { get; set; }
        public string answer { get; set; }

        public string data { get; set; }
    }
    public class Game
    {
        public List<Card> cards { get; set; } = new List<Card>()
        {
            new Card() { image = "athletisme.jpg", answer = "centre social cocteau"},
            new Card() { image = "aviron.jpg", answer = ""},
            new Card() { image = "badminton.jpg", answer = ""},
            new Card() { image = "basketball.jpg", answer = ""},
            new Card() { image = "3x3basketball.jpg", answer = ""},
        };
    }
}
