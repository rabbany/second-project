using FairManagementSystemVer1.BLL;
using FairManagementSystemVer1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FairManagementSystemVer1.UI
{
    public partial class ZoneWiseVisitorUI : Form
    {
        public ZoneWiseVisitorUI()
        {
            InitializeComponent();
        }

        private void ZoneWiseVisitorUI_Load(object sender, EventArgs e)
        {
            VisitorZoneManger visitorzonemanager = new VisitorZoneManger();
            List<VisitorEntry> visitor;
            visitor = visitorzonemanager.GetCountVisitorList();
            ZoneCountListView.Items.Clear();
            int serialNo = 1;
            int visitorcount=0;
            foreach (VisitorEntry v in visitor)
            {
                ListViewItem anItem = new ListViewItem(serialNo.ToString());
                anItem.Tag = (VisitorEntry)v;

                anItem.SubItems.Add(v.Name);
                anItem.SubItems.Add(v.Email);
                
                ZoneCountListView.Items.Add(anItem);
                serialNo++;
                visitorcount = visitorcount + int.Parse(v.Email);
            }

            totalVisitortextBox.Text = visitorcount.ToString();
        }
    }
}
