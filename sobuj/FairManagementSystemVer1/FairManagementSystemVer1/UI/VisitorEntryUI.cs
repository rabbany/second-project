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

namespace FairManagementSystemVer1
{
    public partial class VisitorEntryUI : Form
    {
        private string mode = "";
        private int visitorId = 0;
        VisitorManager visitorManager=new VisitorManager();
        public VisitorEntryUI(string mode, int visitorId)
        {
            InitializeComponent();
            if (mode == "Update")
            {
                VisitorEntry visitor = visitorManager.GetVisitorById(visitorId);
                visitorNameTextBox.Text = visitor.Name;
               // Doctor doctor = VisitorManager.GetDoctorByPatientId(visitorId);
              
                List<Zone> visitorZoneList = new List<Zone>();
                List<Zone> zoneList = new List<Zone>();
                ZoneManager zoneManager = new ZoneManager();
                visitorZoneList = zoneManager.GetZoneByVisitorId(visitorId);
                zoneList = zoneManager.GetZoneList();
                zoneCheckedListBox.DataSource = null;
                zoneCheckedListBox.DataSource = zoneList;
                zoneCheckedListBox.ValueMember = "Id";
                zoneCheckedListBox.DisplayMember = "Name";
                for (int index = 0; index < zoneList.Count; index++)
                {
                    foreach (var zoneIndex in visitorZoneList)
                    {
                        if (zoneList[index].Id == zoneIndex.Id)
                        {
                            zoneCheckedListBox.SetItemChecked(index, true);
                            break;
                        }
                    }
                }
                this.mode = mode;
                this.visitorId = visitorId;
            }
            else
            {
              //  GetDoctorsListInComboBox();
                GetZoneListInZoneCheckedListBox();
            }
        }

        /*public VisitorEntryUI()
        {
            // TODO: Complete member initialization
        }*/
        private void GetZoneListInZoneCheckedListBox()
        {
            ZoneManager zoneManager = new ZoneManager();
            List<Zone> zoneList = new List<Zone>();
            zoneList = zoneManager.GetZoneList();
            zoneCheckedListBox.DataSource = null;
            zoneCheckedListBox.DataSource = zoneList;
            zoneCheckedListBox.ValueMember = "Id";
            zoneCheckedListBox.DisplayMember = "Name";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            VisitorManager visitorManager = new VisitorManager();
            VisitorZoneManger visitorZoneManager = new VisitorZoneManger();
            VisitorEntry visitorEntry = new VisitorEntry();
           // visitorEntry.ID = visitorId;
            visitorEntry.Name = visitorNameTextBox.Text;
            visitorEntry.Email = emailTextBox.Text;
            visitorEntry.CNumber = contactNumberTextBox.Text;
            


            


            if (visitorEntry.Name!="" && visitorEntry.Email!=""&&visitorEntry.CNumber!="")
            {
              int visitorID =   visitorManager.Save(visitorEntry);
                
                    foreach (var index in zoneCheckedListBox.CheckedItems)
                    {
                        Zone zone = (Zone)index;
                        ZoneType zonetype = new ZoneType();
                        zonetype.VisitorId = visitorID;
                        zonetype.ZoneId = zone.Id;
                        visitorZoneManager.Save(zonetype);
                    }
                    
                    


                    Close();
                    MessageBox.Show("Visitor Successfully Added");
                
                

               // int retrievedVisitorId = visitorZoneManager.Save(visitorEntry);
               // if (retrievedVisitorId > 0)
               // {
                   // foreach (var index in zoneCheckedListBox.CheckedItems)
                    //{
                        //Zone zone = (Zone)index;
                        //ZoneType zoneType = new ZoneType();
                        //zoneType.VisitorId = retrievedVisitorId;
                        //zoneType.ZoneId = zone.Id;
                        //VisitorZoneManger.Save(zoneType);
                   // }
                   // Close();
                   // MessageBox.Show("Visitor Successfully Saved");                  
              //  }
            }
          /*  else if(visitorEntry.Name!="")
            {
                int retrievedVisitorId = VisitorManager.Save1();
                if (retrievedVisitorId > 0)
                {
                    foreach (var index in zoneCheckedListBox.CheckedItems)
                    {
                        Zone zone = (Zone)index;
                        ZoneType zoneType = new ZoneType();
                        zoneType.VisitorId = retrievedVisitorId;
                         zoneType.ZoneId  = zone.Id;
                        VisitorZoneManger.Save(zoneType);
                    }
                    Close();
                    MessageBox.Show("Visitor Successfully Saved");
                }
            }*/
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void VisitorEntryUI_Load(object sender, EventArgs e)
        {

        }


        }
    }

