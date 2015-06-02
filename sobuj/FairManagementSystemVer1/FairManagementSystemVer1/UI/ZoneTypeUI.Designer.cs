namespace FairManagementSystemVer1.UI
{
    partial class ZoneTypeUI
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.zoneEntryListView = new System.Windows.Forms.ListView();
            this.serialColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zonetypeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zoneGroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.typenameLabel = new System.Windows.Forms.Label();
            this.typenameTextBox = new System.Windows.Forms.TextBox();
            this.zoneGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // zoneEntryListView
            // 
            this.zoneEntryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serialColumnHeader,
            this.zonetypeColumnHeader});
            this.zoneEntryListView.GridLines = true;
            listViewItem1.IndentCount = 1;
            this.zoneEntryListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.zoneEntryListView.Location = new System.Drawing.Point(14, 155);
            this.zoneEntryListView.Name = "zoneEntryListView";
            this.zoneEntryListView.Size = new System.Drawing.Size(419, 197);
            this.zoneEntryListView.TabIndex = 3;
            this.zoneEntryListView.UseCompatibleStateImageBehavior = false;
            this.zoneEntryListView.View = System.Windows.Forms.View.Details;
            // 
            // serialColumnHeader
            // 
            this.serialColumnHeader.Text = "Serial No";
            this.serialColumnHeader.Width = 92;
            // 
            // zonetypeColumnHeader
            // 
            this.zonetypeColumnHeader.Text = "Zone Type";
            this.zonetypeColumnHeader.Width = 321;
            // 
            // zoneGroupBox
            // 
            this.zoneGroupBox.Controls.Add(this.saveButton);
            this.zoneGroupBox.Controls.Add(this.typenameLabel);
            this.zoneGroupBox.Controls.Add(this.typenameTextBox);
            this.zoneGroupBox.Location = new System.Drawing.Point(12, 31);
            this.zoneGroupBox.Name = "zoneGroupBox";
            this.zoneGroupBox.Size = new System.Drawing.Size(421, 95);
            this.zoneGroupBox.TabIndex = 2;
            this.zoneGroupBox.TabStop = false;
            this.zoneGroupBox.Text = "Zone Type";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(282, 66);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // typenameLabel
            // 
            this.typenameLabel.AutoSize = true;
            this.typenameLabel.Location = new System.Drawing.Point(38, 36);
            this.typenameLabel.Name = "typenameLabel";
            this.typenameLabel.Size = new System.Drawing.Size(62, 13);
            this.typenameLabel.TabIndex = 1;
            this.typenameLabel.Text = "Type Name";
            // 
            // typenameTextBox
            // 
            this.typenameTextBox.Location = new System.Drawing.Point(153, 29);
            this.typenameTextBox.Name = "typenameTextBox";
            this.typenameTextBox.Size = new System.Drawing.Size(204, 20);
            this.typenameTextBox.TabIndex = 0;
            // 
            // ZoneTypeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 374);
            this.Controls.Add(this.zoneEntryListView);
            this.Controls.Add(this.zoneGroupBox);
            this.Name = "ZoneTypeUI";
            this.Text = "ZoneTypeUI";
            this.Load += new System.EventHandler(this.ZoneTypeUI_Load);
            this.zoneGroupBox.ResumeLayout(false);
            this.zoneGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView zoneEntryListView;
        private System.Windows.Forms.ColumnHeader serialColumnHeader;
        private System.Windows.Forms.ColumnHeader zonetypeColumnHeader;
        private System.Windows.Forms.GroupBox zoneGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label typenameLabel;
        private System.Windows.Forms.TextBox typenameTextBox;
    }
}