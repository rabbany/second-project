namespace FairManagementSystemVer1.UI
{
    partial class ZoneWiseVisitorUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.totalVisitortextBox = new System.Windows.Forms.TextBox();
            this.ZoneCountListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalVisitortextBox
            // 
            this.totalVisitortextBox.Location = new System.Drawing.Point(360, 292);
            this.totalVisitortextBox.Name = "totalVisitortextBox";
            this.totalVisitortextBox.Size = new System.Drawing.Size(155, 20);
            this.totalVisitortextBox.TabIndex = 5;
            // 
            // ZoneCountListView
            // 
            this.ZoneCountListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ZoneCountListView.FullRowSelect = true;
            this.ZoneCountListView.GridLines = true;
            this.ZoneCountListView.Location = new System.Drawing.Point(16, 21);
            this.ZoneCountListView.Name = "ZoneCountListView";
            this.ZoneCountListView.Size = new System.Drawing.Size(499, 254);
            this.ZoneCountListView.TabIndex = 3;
            this.ZoneCountListView.UseCompatibleStateImageBehavior = false;
            this.ZoneCountListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Zone";
            this.columnHeader2.Width = 266;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "No of Visitors";
            this.columnHeader3.Width = 157;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total";
            // 
            // ZoneWiseVisitorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 350);
            this.Controls.Add(this.totalVisitortextBox);
            this.Controls.Add(this.ZoneCountListView);
            this.Controls.Add(this.label1);
            this.Name = "ZoneWiseVisitorUI";
            this.Text = "ZoneWiseVisitorUI";
            this.Load += new System.EventHandler(this.ZoneWiseVisitorUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox totalVisitortextBox;
        private System.Windows.Forms.ListView ZoneCountListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
    }
}