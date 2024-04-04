using Domain.Enum;

namespace Domain.Entities
{
    public class Entrance
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public int NumberFloor { get; set; }
        public int NumberApartmentPerFloor { get; set; }
        public bool HasLift { get; set; }
        public Building Building { get; set; }
        public Guid BuildingId { get; set; }
        public virtual ICollection<Apartment> Apartments { get; set; }
    }
}
