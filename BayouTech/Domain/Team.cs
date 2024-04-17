namespace BayouTech.Domain
{
    public class Team
    {
        public string TeamName { get; set; }

        public string Stadium { get; set; }

        public string Coach { get; set; }

        public List<Player> Players { get; set; }
    }
}
