using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleshipGUI
{
    public partial class VerticalLabel : UserControl
    {
        public VerticalLabel()
        {
            CreateLabels();
            InitializeComponent();
        }
        private void CreateLabels()
        {
            labels = new Label[size];
            for (int i = 0; i < size; ++i)
            {
                labels[i] = new Label() { TextAlign = ContentAlignment.MiddleCenter };
                labels[i].Text = (i + 1).ToString();
                Controls.Add(labels[i]);
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            int labelHeight = ClientSize.Height / size;
            int top = 0;
            for (int i = 0; i < size; ++i)
            {
                labels[i].Width = labelHeight;
                labels[i].Top = top;
                top += labelHeight;
            }

        }

        public Label[] labels;
        private int size = 10;
    }
}
