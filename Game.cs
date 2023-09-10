using System.Reflection.Metadata;
using System.Text.Json;

namespace cousinzins2023
{
    public class Answers
    {
        public string[] values { get; set; }
    }

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
            new Card() { image = "3x3basketball.jpg", answer = "ESBVA"},
            new Card() { image = "athletisme.jpg", answer = "athletisme"},
            new Card() { image = "aviron.jpg", answer = "AAATV"},
            new Card() { image = "badminton.jpg", answer = "alpjj"},
            // new Card() { image = "basketball.jpg", answer = "basketball"},
            new Card() { image = "canoe.jpg", answer = "soutien pc"},
            // new Card() { image = "concours.jpg", answer = "concours"},
            // new Card() { image = "cyclisme_sur_piste.jpg", answer = "cyclisme_sur_piste"},
            // new Card() { image = "escalade.jpg", answer = "escalade"},
            // new Card() { image = "escrime.jpg", answer = "escrime"},
            new Card() { image = "football.jpg", answer = "office de tourisme de villeneuve d'ascq"},
            //new Card() { image = "golf.jpg", answer = "golf"},
            new Card() { image = "judo.jpg", answer = "judo club flers sart"},
            //new Card() { image = "rugby_a_sept.jpg", answer = "judo"},
            new Card() { image = "tennis.jpg", answer = "la raquette"},
            new Card() { image = "tir.jpg", answer = "alpjj"}
        };

        public string GetAnswers()
        {
            string tmp = JsonSerializer.Serialize(new Answers() { values = cards.Select(_ => _.data).ToArray() });
            return tmp;
        }

        public void SetAnswers(string json)
        {
            Answers a = JsonSerializer.Deserialize<Answers>(json);
            for (int i = 0; i < Math.Min(a.values.Length, cards.Count); i++)
            {
                cards[i].data = a.values[i];
            }
        }
    }
}
