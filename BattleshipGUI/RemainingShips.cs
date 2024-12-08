using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vsite.Oom.Battleship.Model;

namespace BattleshipGUI
{
    public partial class RemainingShips : UserControl
    {

        private readonly Dictionary<int, int> remainingShips = new Dictionary<int, int>();

        public RemainingShips()
        {
            InitializeComponent();
        }

        public void UpdateRemainingShips(Fleet fleet)
        {
            remainingShips.Clear();

            foreach (int length in fleet.Ships.Select(ship => ship.Squares.Count()).Distinct())
            {
                int count = fleet.Ships.Count(ship => ship.Squares.Count() == length && ship.Squares.Any(s => s.SquareState != SquareState.Sunk));
                remainingShips[length] = count;
            }

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int cellSize = Math.Min(ClientSize.Width / 3, ClientSize.Height / 10);

            int x = 0;
            int y = 0;
            int spacing = cellSize / 5;

            foreach (var kvp in remainingShips)
            {
                int length = kvp.Key;
                int count = kvp.Value;

                for (int i = 0; i < count; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        Rectangle rect = new Rectangle(x + j * (cellSize + spacing), y + i * (cellSize + spacing * 5), cellSize, cellSize);
                        using (Brush brush = new SolidBrush(Color.Blue))
                        {
                            e.Graphics.FillRectangle(brush, rect);
                        }
                    }
                }

                x += (length + 1) * (cellSize + spacing);
            }
        }
    }
}