using FairManagementSystemVer1.BLL;
using FairManagementSystemVer1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FairManagementSystemVer1.UI
{
    public partial class ZoneSpecificVisitorUI : Form
    {

        public ZoneSpecificVisitorUI()
        {
            InitializeComponent();
        }

        private void ZoneSpecificVisitorUI_Load(object sender, EventArgs e)
        {
            GetZoneListInComboBox();
            Search();

        }

        private void Search()
        {
            VisitorZoneManger visitorzonemanager = new VisitorZoneManger();
            List<VisitorEntry> visitor;
            visitor = visitorzonemanager.GetInfoVisitorList((int) zoneComboBox.SelectedValue);
            showListView.Items.Clear();
            int serialNo = 1;
            foreach (VisitorEntry v in visitor)
            {
                ListViewItem anItem = new ListViewItem(serialNo.ToString());
                anItem.Tag = (VisitorEntry) v;

                anItem.SubItems.Add(v.Name);
                anItem.SubItems.Add(v.Email);
                anItem.SubItems.Add(v.CNumber);
                showListView.Items.Add(anItem);
                serialNo++;
            }

            totalTextBox.Text = (serialNo - 1).ToString();

        }

        private void GetZoneListInComboBox()
        {
            ZoneManager zoneManager = new ZoneManager();
            List<Zone> zoneList = new List<Zone>();
            zoneList = zoneManager.GetZoneList();
            zoneComboBox.DataSource = null;
            zoneComboBox.DataSource = zoneList;
            zoneComboBox.ValueMember = "Id";
            zoneComboBox.DisplayMember = "Name";

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            // Export2Excel();
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet) wb.Worksheets[1];
            int i = 1;
            int i2 = 1;
            foreach (ListViewItem lvi in showListView.Items)
            {
                i = 1;
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    ws.Cells[i2, i] = lvs.Text;
                    i++;
                }
                i2++;

            }

            //private void Export2Excel()
            //{
            //    try
            //    {

            //        string[] st = new string[showListView.Columns.Count];
            //        DirectoryInfo di = new DirectoryInfo(@"c:\PDFExtraction\");
            //        if (di.Exists == false)
            //            di.Create();
            //        StreamWriter sw = new StreamWriter(@"c:\PDFExtraction\Mithun.xls", false);
            //        sw.AutoFlush = true;
            //        for (int col = 0; col < showListView.Columns.Count; col++)
            //        {
            //            sw.Write(showListView.Columns[col].Text.ToString()+"\t" );
            //        }
            //        sw.Write("\n");
            //        int rowIndex = 1;
            //        int row = 0;
            //        string st1 = "";
            //        for (row = 0; row < showListView.Items.Count; row++)
            //        {
            //            if (rowIndex <= showListView.Items.Count)
            //                rowIndex++;
            //            st1 = "";
            //            for (int col = 0; col < showListView.Columns.Count; col++)
            //            {
            //                st1 = st1 + showListView.Items[row].SubItems[col].Text.ToString() + "\t";
            //            }
            //            sw.WriteLine(st1);
            //        }
            //        sw.Close();
            //        FileInfo fil = new FileInfo(@"c:\PDFExtraction\Mithun.xls");
            //        if (fil.Exists == true)
            //            MessageBox.Show("Process Completed", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    catch (Exception ex)
            //    {
            //    }
            //}

        }
    }
}

