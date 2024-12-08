using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGUI
{
    internal class GridButton : Button
    {
        public readonly int Row;
        public readonly int Column;
        public GridButton(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
