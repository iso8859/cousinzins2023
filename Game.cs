namespace cousinzins2023
{
    public class Card
    {
        public string image { get; set; }
        public string answer { get; set; }
        public string data { get; set; }

        public string status()
        {
            return isCorrect() ? "correcte" : "incorrecte";
        }

        public bool isCorrect()
        {
            if (string.IsNullOrEmpty(answer) || string.IsNullOrEmpty(data)) return false;
            if (answer.ToLower().Trim() == data.ToLower().Trim()) return true;
            return false;
        }
    }
    public class Game
    {
        public List<Card> cards { get; set; } = new List<Card>()
        {
            new Card() { image = "3x3basketball.jpg", answer = "3x3basketball"},
            new Card() { image = "athletisme.jpg", answer = "athletisme"},
            new Card() { image = "aviron.jpg", answer = "aviron"},
            new Card() { image = "badminton.jpg", answer = "badminton"},
            new Card() { image = "basketball.jpg", answer = "basketball"},
            new Card() { image = "canoe.jpg", answer = "canoe"},
            new Card() { image = "concours.jpg", answer = "concours"},
            new Card() { image = "cyclisme_sur_piste.jpg", answer = "cyclisme_sur_piste"},
            new Card() { image = "escalade.jpg", answer = "escalade"},
            new Card() { image = "escrime.jpg", answer = "escrime"},
            new Card() { image = "football.jpg", answer = "football"},
            new Card() { image = "golf.jpg", answer = "golf"},
            new Card() { image = "judo.jpg", answer = ""},
            new Card() { image = "rugby_a_sept.jpg", answer = "judo"},
            new Card() { image = "tennis.jpg", answer = "tennis"},
            new Card() { image = "tir.jpg", answer = "tir"}
        };
    }
}
