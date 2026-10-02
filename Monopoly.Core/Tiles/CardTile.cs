using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly.Core.Tiles {
    public class CardTile : Tile {

        public DeckType deckType;
        public override void OnLanded(Player player, Game game) {
            throw new NotImplementedException();
        }
    }
}
