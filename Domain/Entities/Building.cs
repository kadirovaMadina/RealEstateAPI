﻿using Domain.Enum;

namespace Domain.Entities
{
    public class Building
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Address { get; set; } = String.Empty;
        public int EntrancesCount { get; set; }
        public double CeilingHeight { get; set; }
        public bool RestSector { get; set; }
        public bool HasLift { get; set; }
        public BuildingMaterial Material { get; set; }
        public BuildingClass BuildingClass { get; set; }

        public virtual ICollection<Entrance> Entrances { get; set; }
    }
}
