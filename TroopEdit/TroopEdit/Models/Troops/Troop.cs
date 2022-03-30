using System.Collections.Generic;

namespace TroopEdit.Models.Troops
{
    public class Troop
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Target { get; set; }
        public int? Damage { get; set; } = null;
        public int? Health { get; set; } = null;
        public List<Troop> DerivedTroops { get; set; }
    }
}
