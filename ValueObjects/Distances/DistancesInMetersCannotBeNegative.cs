using System;
using System.Runtime.Serialization;

namespace ValueObjects.Distances
{
    [Serializable]
    internal class DistancesInMetersCannotBeNegative : Exception
    {
        public DistancesInMetersCannotBeNegative()
        {
        }

        public DistancesInMetersCannotBeNegative(string message) : base(message)
        {
        }

        public DistancesInMetersCannotBeNegative(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DistancesInMetersCannotBeNegative(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}