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
    public partial class HorizontalLabel : UserControl
    {
        public HorizontalLabel()
        {
            CreateLabels();
            InitializeComponent();
        }
        private void CreateLabels()
        {
            labels = new Label[size];
            char c = 'A';
            for (int i = 0; i < size; ++i, ++c)
            {
                labels[i] = new Label() { TextAlign = ContentAlignment.MiddleCenter };
                labels[i].Text = c.ToString();
                Controls.Add(labels[i]);
            }
        }


        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            int labelWidth = ClientSize.Width / size;
            int left = 0;
            for (int i = 0; i < size; ++i)
            {
                labels[i].Width = labelWidth;
                labels[i].Left = left;
                left += labelWidth;
            }

        }

        public Label[] labels;
        private int size = 10;
    }
}
