using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly.Core.Tiles {
    public class TaxTile : Tile {
        public int AmountPerProperty;
        public override void OnLanded(Player player, Game game) {
            throw new NotImplementedException();
        }
    }
}
