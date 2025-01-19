namespace FlipIt.API.Models
{
    public class Build : EntityBase
    {
        public List<Component>? Components { get; set; }

        public DateTime? DateListed { get; set; }
        public DateTime? DateSold { get; set; }

        public double? BuildCost { get; set; }

        public string? Description { get; set; }
    }
}
