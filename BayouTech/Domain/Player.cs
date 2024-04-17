namespace BayouTech.Domain
{
    public class Player : BaseEntity
    {
        public string PlayerName { get; set; }

        public string CollegeName { get; set; }

        public string Position { get; set; }

        public DateTime BirthDate { get; set; }

    }
}
