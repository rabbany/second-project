using FairManagementSystemVer1.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FairManagementSystemVer1
{
    public partial class MainFormUI : Form
    {
        public MainFormUI()
        {
            InitializeComponent();
        }

        private void visitorEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitorEntryUI visitorEntryUI = new VisitorEntryUI(null, 0);
            visitorEntryUI.Show();
        }

        private void zoneTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneTypeUI zoneTypeUI = new ZoneTypeUI();
            zoneTypeUI.Show();
        }

        private void zoneSpecificVisitorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneSpecificVisitorUI zoneSpecificVisitorUI = new ZoneSpecificVisitorUI();
            zoneSpecificVisitorUI.Show();
        }

        private void zoneWiseVisitorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneWiseVisitorUI zoneWiseVisitorUI = new ZoneWiseVisitorUI();
            zoneWiseVisitorUI.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
