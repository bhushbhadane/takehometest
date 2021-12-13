namespace FixtureWeb.DAL.Models
{
    public class Markets
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Price { get; set; }

        public virtual Fixture Fixture { get; set; }
    }
}
