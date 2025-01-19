namespace FlipIt.API.Models
{
    public class Component : EntityBase
    {
        public Guid PartId { get; set; }
        public Part Part { get; set; }
        public string Name { get; set; }   
        public double Price { get; set; }
        public string Details { get; set; }

        public Guid VendorId { get; set; } 

        public Vendor Vendor { get; set; }
        public Guid? BuildId { get; set; }

        //navigation property
        public Build Build { get; set; }
    }
}
