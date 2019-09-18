using System;
using System.Collections.Generic;
using System.Text;

namespace ValueObjects.Distances
{
    public class Meters
    {
        public Meters(decimal distanceInMeters)
        {
            if (distanceInMeters < (decimal)0.0)
                throw new DistancesInMetersCannotBeNegative();
            this.DistanceInMeters = distanceInMeters;
        }
        protected decimal DistanceInMeters { get; private set; }
        public Yards ToYards()
        {
            return new Yards(DistanceInMeters * (decimal)1.0936133);
        }
        public Kilometers ToKilometers()
        {
            return new Kilometers(DistanceInMeters / 1000);
        }
        public Meters Add(Meters meters)
        {
            return new Meters(
            this.DistanceInMeters + meters.DistanceInMeters
            );
        }
        public bool IsLongerThan(Meters meters)
        {
            return this.DistanceInMeters > meters.DistanceInMeters;
        }
        public override bool Equals(object obj)
        {
            var m = obj as Meters;
            if (m == null) return false;
            return ToTwoDecimalPlaces(m.DistanceInMeters)
            == ToTwoDecimalPlaces(DistanceInMeters);
        }
        private decimal ToTwoDecimalPlaces(decimal distanceInMeters)
        {
            return Math.Round(
            distanceInMeters, 2, MidpointRounding.AwayFromZero
            );
        }

        public override int GetHashCode()
        {
            return -177055885 + DistanceInMeters.GetHashCode();
        }
    }
}
