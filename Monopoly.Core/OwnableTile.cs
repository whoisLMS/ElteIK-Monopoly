using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly.Core {
    public abstract class OwnableTile : Tile {
        public int Price;
        public int MortgageValue;
        public bool IsMortgaged;
        public Player Owner;

        public int CalculateRent(Game game) {
            throw new NotImplementedException();
        }

        public void Mortgage() {
            throw new NotImplementedException();
        }

        public void UnMortgage() {
            throw new NotImplementedException();
        }

        public override void OnLanded(Player player, Game game) {
            throw new NotImplementedException();
        }
    }
}
