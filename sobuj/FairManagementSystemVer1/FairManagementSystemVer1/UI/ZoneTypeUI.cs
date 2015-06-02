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
    public partial class ZoneTypeUI : Form
    {
        public ZoneTypeUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ZoneManager zoneManager = new ZoneManager();
            Zone zone = new Zone();
            zone.Name = typenameTextBox.Text;
            if (zoneManager.Save(zone))
            {
                Close();
                MessageBox.Show("Zone Successfully Added");
            }
        }

        private void ZoneTypeUI_Load(object sender, EventArgs e)
        {
            GetZoneList();
        }
        private void GetZoneList()
        {
            ZoneManager zoneManager = new ZoneManager();
            List<Zone> zoneList = zoneManager.GetZoneList();
            foreach (var index in zoneList)
            {
                ListViewItem listViewItem = new ListViewItem(index.Id.ToString());
                listViewItem.SubItems.Add(index.Name);
                listViewItem.Tag = index.Id;
                zoneEntryListView.Items.Add(listViewItem);
            }
        }
    }
}
