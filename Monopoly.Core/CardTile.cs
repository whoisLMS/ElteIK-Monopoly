using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly.Core {
    public class CardTile : Tile {

        public DeckType deckType;
        public override void OnLanded(Player player, Game game) {
            throw new NotImplementedException();
        }
    }
}
