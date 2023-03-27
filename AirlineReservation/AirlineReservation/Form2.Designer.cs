
namespace AirlineReservation
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.tableNameHeader = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deletePanel = new System.Windows.Forms.Panel();
            this.msgBox = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.airlineID = new System.Windows.Forms.TextBox();
            this.crafts = new System.Windows.Forms.TextBox();
            this.airlineName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.deletePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(46)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 544);
            this.panel1.TabIndex = 65;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.label6);
            this.panel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel7.Location = new System.Drawing.Point(0, 133);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(134, 143);
            this.panel7.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 30;
            this.label6.Text = "Dashboard";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(134, 135);
            this.backBtn.TabIndex = 36;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // tableNameHeader
            // 
            this.tableNameHeader.AutoSize = true;
            this.tableNameHeader.Font = new System.Drawing.Font("Arial", 21F);
            this.tableNameHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.tableNameHeader.Location = new System.Drawing.Point(358, 86);
            this.tableNameHeader.Name = "tableNameHeader";
            this.tableNameHeader.Size = new System.Drawing.Size(361, 32);
            this.tableNameHeader.TabIndex = 67;
            this.tableNameHeader.Text = "Add A New Airline Company";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.label3.Location = new System.Drawing.Point(223, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Airline Reservation System";
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Red;
            this.exitBtn.Location = new System.Drawing.Point(841, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(46, 40);
            this.exitBtn.TabIndex = 37;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.label2.Location = new System.Drawing.Point(301, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(133, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(887, 83);
            this.panel2.TabIndex = 68;
            // 
            // deletePanel
            // 
            this.deletePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.deletePanel.Controls.Add(this.msgBox);
            this.deletePanel.Controls.Add(this.label8);
            this.deletePanel.Controls.Add(this.label7);
            this.deletePanel.Controls.Add(this.label10);
            this.deletePanel.Controls.Add(this.airlineID);
            this.deletePanel.Controls.Add(this.crafts);
            this.deletePanel.Controls.Add(this.airlineName);
            this.deletePanel.Controls.Add(this.label5);
            this.deletePanel.Controls.Add(this.label4);
            this.deletePanel.Controls.Add(this.label111);
            this.deletePanel.Controls.Add(this.saveButton);
            this.deletePanel.Location = new System.Drawing.Point(134, 133);
            this.deletePanel.Margin = new System.Windows.Forms.Padding(2);
            this.deletePanel.Name = "deletePanel";
            this.deletePanel.Size = new System.Drawing.Size(886, 411);
            this.deletePanel.TabIndex = 70;
            // 
            // msgBox
            // 
            this.msgBox.AutoSize = true;
            this.msgBox.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.msgBox.ForeColor = System.Drawing.Color.White;
            this.msgBox.Location = new System.Drawing.Point(287, 333);
            this.msgBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(245, 18);
            this.msgBox.TabIndex = 88;
            this.msgBox.Text = "\"Your Data has been saved😊\"";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(393, 237);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 14);
            this.label8.TabIndex = 87;
            this.label8.Text = "*String of max length 50*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(393, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 14);
            this.label7.TabIndex = 86;
            this.label7.Text = "*String of max length 50*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(393, 120);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 14);
            this.label10.TabIndex = 85;
            this.label10.Text = "*String should have exact length 5*";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // airlineID
            // 
            this.airlineID.Location = new System.Drawing.Point(393, 101);
            this.airlineID.Margin = new System.Windows.Forms.Padding(2);
            this.airlineID.Name = "airlineID";
            this.airlineID.Size = new System.Drawing.Size(196, 20);
            this.airlineID.TabIndex = 80;
            // 
            // crafts
            // 
            this.crafts.Location = new System.Drawing.Point(393, 218);
            this.crafts.Margin = new System.Windows.Forms.Padding(2);
            this.crafts.Name = "crafts";
            this.crafts.Size = new System.Drawing.Size(196, 20);
            this.crafts.TabIndex = 79;
            // 
            // airlineName
            // 
            this.airlineName.Location = new System.Drawing.Point(395, 163);
            this.airlineName.Margin = new System.Windows.Forms.Padding(2);
            this.airlineName.Name = "airlineName";
            this.airlineName.Size = new System.Drawing.Size(195, 20);
            this.airlineName.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(212, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 77;
            this.label5.Text = "Airline Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(212, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 18);
            this.label4.TabIndex = 76;
            this.label4.Text = "Airline Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label111.ForeColor = System.Drawing.Color.White;
            this.label111.Location = new System.Drawing.Point(212, 101);
            this.label111.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(84, 18);
            this.label111.TabIndex = 74;
            this.label111.Text = "Airline ID";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(371, 284);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(69, 32);
            this.saveButton.TabIndex = 55;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(983, 500);
            this.Controls.Add(this.deletePanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableNameHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.deletePanel.ResumeLayout(false);
            this.deletePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label tableNameHeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel deletePanel;
        private System.Windows.Forms.Label msgBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox airlineID;
        private System.Windows.Forms.TextBox crafts;
        private System.Windows.Forms.TextBox airlineName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Button saveButton;
    }
}