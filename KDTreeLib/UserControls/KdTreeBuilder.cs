using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KdTreeLib
{
    public partial class KdTreeBuilder : UserControl
    {
        public KdTreeBuilder()
        {
            InitializeComponent();
        }

        private void KdTreeBuilder_Click(object sender, EventArgs e)
        {

        }

        private void KdTreeBuilder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KdTreeBuilder_StyleChanged(object sender, EventArgs e)
        {

        }

        private void KdTreeBuilder_Resize(object sender, EventArgs e)
        {

        }

        private void KdTreeBuilder_MouseLeave(object sender, EventArgs e)
        {

        }
    }
    public class NeighborEventArgs : EventArgs
    {
        public KdNode Neighbor { get; set; }
    }
}
