namespace FairManagementSystemVer1
{
    partial class VisitorEntryUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contactNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.visitorNameTextBox = new System.Windows.Forms.TextBox();
            this.visitorNameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.zoneCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.contactNumberTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.visitorNameTextBox);
            this.groupBox1.Controls.Add(this.visitorNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visitor\'s Information";
            // 
            // contactNumberTextBox
            // 
            this.contactNumberTextBox.Location = new System.Drawing.Point(172, 96);
            this.contactNumberTextBox.Name = "contactNumberTextBox";
            this.contactNumberTextBox.Size = new System.Drawing.Size(251, 20);
            this.contactNumberTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contact number :";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(172, 53);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(251, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email :";
            // 
            // visitorNameTextBox
            // 
            this.visitorNameTextBox.Location = new System.Drawing.Point(172, 16);
            this.visitorNameTextBox.Name = "visitorNameTextBox";
            this.visitorNameTextBox.Size = new System.Drawing.Size(251, 20);
            this.visitorNameTextBox.TabIndex = 1;
            // 
            // visitorNameLabel
            // 
            this.visitorNameLabel.AutoSize = true;
            this.visitorNameLabel.Location = new System.Drawing.Point(31, 23);
            this.visitorNameLabel.Name = "visitorNameLabel";
            this.visitorNameLabel.Size = new System.Drawing.Size(41, 13);
            this.visitorNameLabel.TabIndex = 0;
            this.visitorNameLabel.Text = "Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.zoneCheckedListBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zone type visitor\'s want to visit";
            // 
            // zoneCheckedListBox
            // 
            this.zoneCheckedListBox.FormattingEnabled = true;
            this.zoneCheckedListBox.Location = new System.Drawing.Point(45, 19);
            this.zoneCheckedListBox.Name = "zoneCheckedListBox";
            this.zoneCheckedListBox.Size = new System.Drawing.Size(367, 124);
            this.zoneCheckedListBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(360, 362);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // VisitorEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 408);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VisitorEntryUI";
            this.Text = "VisitorEntryUI";
            this.Load += new System.EventHandler(this.VisitorEntryUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox contactNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox visitorNameTextBox;
        private System.Windows.Forms.Label visitorNameLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckedListBox zoneCheckedListBox;

    }
}

