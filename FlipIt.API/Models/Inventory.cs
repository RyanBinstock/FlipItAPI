namespace FlipIt.API.Models
{
    public class Inventory : EntityBase
    {
        public List<Component> Components { get; set; }

        public List<Build> Builds { get; set; }

        public double TotalCost { get; set; }
    }
}
