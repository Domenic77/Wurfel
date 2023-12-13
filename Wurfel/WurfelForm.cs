using System;
using System.Windows.Forms;

namespace Wurfel
{
    public partial class WurfelForm : Form
    {
        Wuerfeln wuerfel = new Wuerfeln();
        public WurfelForm()
        {
            InitializeComponent();
        }

        private void WurfelnButton_Click(object sender, EventArgs e)
        {
            int wurf = wuerfel.werfen();
            TrowValueLabel.Text = wurf.ToString();
            LasThrowValueLabel.Text = wuerfel.LetzterWurf.ToString();
        }
    }
}
