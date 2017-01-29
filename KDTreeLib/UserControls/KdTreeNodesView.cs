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
    public partial class KdTreeNodesView : UserControl
    {
        public KdTreeNodesView()
        {
            InitializeComponent();
        }

        private void KdTreeNodesView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KdTreeNodesView_Load(object sender, EventArgs e)
        {

        }
    }
    // DisplayNode class to help building the tree visualisation
    internal class DisplayNode
    {
        public int Index { get; set; }
        public int Depth { get; set; }
        public KdNode KdNode { get; set; }
        public DisplayNode Left { get; set; }
        public DisplayNode Right { get; set; }
    }
}
