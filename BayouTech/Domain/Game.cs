using System.Runtime.CompilerServices;

namespace BayouTech.Domain
{
    public class Game
    {
        public int Id { get; set; }

        public DateTime GameDate { get; set; }

        public string HomeTeamAbbr { get; set; }

        public string AwayTeamAbbr { get; set; }

        public int HomeTeamScore { get; set; }

        public int AwayTeamScore { get; set; }

        public string Location { get; set; }
    }
}
