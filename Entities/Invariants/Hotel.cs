using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Invariants
{
    public class Hotel
    {
        public Hotel(Guid id, HotelRoomSummary rooms)
        {
            EnforceInvariants(rooms);
            this.Id = id;
            this.Rooms = rooms;
        }
        private void EnforceInvariants(HotelRoomSummary rooms)
        {
            if (rooms.NumberOfSingleRooms < 1 &&
            rooms.NumberOfDoubleRooms < 1 &&
            rooms.NumberOfFamilyRooms < 1)
                throw new Exception("Hotels Must Have Rooms");
        }
        public Guid Id { get; private set; }
        public HotelRoomSummary Rooms { get; private set; }

    }
}
