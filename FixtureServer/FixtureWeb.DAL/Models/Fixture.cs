using System.Collections.Generic;

namespace FixtureWeb.DAL.Models
{
    public class Fixture
    {
        public Fixture()
        {
            Markets = new HashSet<Markets>();
            Metadata = new HashSet<Metadata>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Markets> Markets { get; set; }

        public virtual ICollection<Metadata> Metadata { get; set; }
    }
}
