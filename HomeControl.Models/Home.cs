using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeControl.Models
{
    public class Occupant
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Home Home { get; set; }

        public OccupancyMode Occupancy { get; set; }

        public double DistanceFromHome { get; set; }
    }

    public enum OccupancyMode
    {
        Home,
        Away
    }

    public class Home
    {
        public Home() { }

        public Guid Id { get; set; }

        public ICollection<Room> Rooms { get; set; }

        public ICollection<Device> Devices { get; set; }

        public ICollection<Occupant> Occupants { get; set; }
    }

    public class Room
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }

    public abstract class Device
    {
        public Guid Id { get; set; }
        public Room Room { get; set; }
    }

    public class Thermostate : Device
    {
        public ThermostateMode Mode { get; set; }
        public bool Active { get; set; }
        public decimal TargetTemperature { get; set; }
        public decimal ActualTemperature { get; set; }
    }

    public class Light : Device
    {
        public bool Mode { get; set; }
        public bool Active { get; set; }
        public decimal TargetTemperature { get; set; }
        public decimal ActualTemperature { get; set; }
    }

    public enum ThermostateMode
    {
        Off,
        Manual,
        Auto
    }

}
