using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly.Core {
    public class PropertyTile : OwnableTile {
        public TileColorGroup ColorGroup;
        public int[] Rents;
        public int HouseCost;
        public int Houses;
        public bool HasHotel;

        public override int CalculateRent(Game game) {
            throw new NotImplementedException();
        }

        public bool CanBuild() {
            throw new NotImplementedException();
        }
    }
}
