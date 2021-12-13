namespace FixtureWeb.DAL.Models
{
    public class Result
    {
        public int Id { get; set; }

        public virtual Fixture Fixture { get; set; }

        public virtual Markets Market { get; set; }
    }
}
