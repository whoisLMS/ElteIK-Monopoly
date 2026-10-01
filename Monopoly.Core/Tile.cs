using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly.Core {
    public abstract class Tile {
        public int Index;
        public int Name;

        public abstract void OnLanded(Player player, Game game);
    }
}
