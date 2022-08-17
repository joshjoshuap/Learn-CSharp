namespace JourJournal.Models
{
    public class Journal
    {
        public Guid Id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string body { get; set; }
        public string notes { get; set; }
    }
}
