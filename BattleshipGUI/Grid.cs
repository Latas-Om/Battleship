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
    public partial class Grid : UserControl
    {
        public Grid()
        {
            CreateButtons();
            InitializeComponent();
        }

        private void CreateButtons()
        {
            buttons = new Button[rows, columns];
            for (int r = 0; r < rows; ++r)
            {
                for (int c = 0; c < columns; ++c)
                {
                    buttons[r, c] = new GridButton(r, c);
                    buttons[r, c].Click += button_Click;
                    Controls.Add(buttons[r, c]);
                }
            }
        }


        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            int buttonWidth = ClientSize.Width / columns;
            int buttonHeight = ClientSize.Height / rows;
            int top = 0;
            for (int r = 0; r < rows; ++r)
            {
                int left = 0;
                for (int c = 0; c < columns; ++c)
                {
                    buttons[r, c].Width = buttonWidth;
                    buttons[r, c].Height = buttonHeight;
                    buttons[r, c].Left = left;
                    buttons[r, c].Top = top;
                    left += buttonWidth;
                }
                top += buttonHeight;
            }

        }

        public Button[,] buttons;
        private int rows = 10;
        private int columns = 10;

        public void AttachOpponentButtonClickEvent(EventHandler eventHandler)
        {
            foreach (Button button in buttons)
            {
                button.Click += eventHandler;
            }
        }


        private void button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
