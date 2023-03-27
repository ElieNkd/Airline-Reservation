
namespace AirlineReservation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableNameHeader = new System.Windows.Forms.Label();
            this.deletePanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.airportID = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.airportName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deletePromptLabel = new System.Windows.Forms.Label();
            this.deleteButtonCon = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(134, 531);
            this.panel1.TabIndex = 56;
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
            this.backBtn.Size = new System.Drawing.Size(134, 83);
            this.backBtn.TabIndex = 36;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(134, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 83);
            this.panel2.TabIndex = 57;
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
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Red;
            this.exitBtn.Location = new System.Drawing.Point(840, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(46, 40);
            this.exitBtn.TabIndex = 37;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
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
            // tableNameHeader
            // 
            this.tableNameHeader.AutoSize = true;
            this.tableNameHeader.Font = new System.Drawing.Font("Arial", 21F);
            this.tableNameHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.tableNameHeader.Location = new System.Drawing.Point(414, 86);
            this.tableNameHeader.Name = "tableNameHeader";
            this.tableNameHeader.Size = new System.Drawing.Size(239, 32);
            this.tableNameHeader.TabIndex = 58;
            this.tableNameHeader.Text = "Add A New Airport";
            // 
            // deletePanel
            // 
            this.deletePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.deletePanel.Controls.Add(this.label9);
            this.deletePanel.Controls.Add(this.label8);
            this.deletePanel.Controls.Add(this.label7);
            this.deletePanel.Controls.Add(this.label10);
            this.deletePanel.Controls.Add(this.country);
            this.deletePanel.Controls.Add(this.airportID);
            this.deletePanel.Controls.Add(this.city);
            this.deletePanel.Controls.Add(this.airportName);
            this.deletePanel.Controls.Add(this.label5);
            this.deletePanel.Controls.Add(this.label4);
            this.deletePanel.Controls.Add(this.label1);
            this.deletePanel.Controls.Add(this.deletePromptLabel);
            this.deletePanel.Controls.Add(this.deleteButtonCon);
            this.deletePanel.Location = new System.Drawing.Point(134, 120);
            this.deletePanel.Margin = new System.Windows.Forms.Padding(2);
            this.deletePanel.Name = "deletePanel";
            this.deletePanel.Size = new System.Drawing.Size(883, 411);
            this.deletePanel.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(401, 248);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 14);
            this.label9.TabIndex = 88;
            this.label9.Text = "*String of length 20*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(401, 198);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 14);
            this.label8.TabIndex = 87;
            this.label8.Text = "*String of length 20*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(401, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 14);
            this.label7.TabIndex = 86;
            this.label7.Text = "*String of max length 50*";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 8F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(400, 81);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 14);
            this.label10.TabIndex = 85;
            this.label10.Text = "*String should have exact length 5*";
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(403, 229);
            this.country.Margin = new System.Windows.Forms.Padding(2);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(195, 20);
            this.country.TabIndex = 81;
            // 
            // airportID
            // 
            this.airportID.Location = new System.Drawing.Point(401, 62);
            this.airportID.Margin = new System.Windows.Forms.Padding(2);
            this.airportID.Name = "airportID";
            this.airportID.Size = new System.Drawing.Size(196, 20);
            this.airportID.TabIndex = 80;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(401, 179);
            this.city.Margin = new System.Windows.Forms.Padding(2);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(196, 20);
            this.city.TabIndex = 79;
            // 
            // airportName
            // 
            this.airportName.Location = new System.Drawing.Point(403, 124);
            this.airportName.Margin = new System.Windows.Forms.Padding(2);
            this.airportName.Name = "airportName";
            this.airportName.Size = new System.Drawing.Size(195, 20);
            this.airportName.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(220, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 77;
            this.label5.Text = "Airport Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(220, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 76;
            this.label4.Text = "City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(220, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 75;
            this.label1.Text = "Country";
            // 
            // deletePromptLabel
            // 
            this.deletePromptLabel.AutoSize = true;
            this.deletePromptLabel.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.deletePromptLabel.ForeColor = System.Drawing.Color.White;
            this.deletePromptLabel.Location = new System.Drawing.Point(220, 59);
            this.deletePromptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deletePromptLabel.Name = "deletePromptLabel";
            this.deletePromptLabel.Size = new System.Drawing.Size(88, 18);
            this.deletePromptLabel.TabIndex = 74;
            this.deletePromptLabel.Text = "Airport ID";
            // 
            // deleteButtonCon
            // 
            this.deleteButtonCon.Font = new System.Drawing.Font("Lucida Fax", 12F);
            this.deleteButtonCon.ForeColor = System.Drawing.Color.Black;
            this.deleteButtonCon.Location = new System.Drawing.Point(371, 300);
            this.deleteButtonCon.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButtonCon.Name = "deleteButtonCon";
            this.deleteButtonCon.Size = new System.Drawing.Size(69, 32);
            this.deleteButtonCon.TabIndex = 55;
            this.deleteButtonCon.Text = "Add";
            this.deleteButtonCon.UseVisualStyleBackColor = true;
            this.deleteButtonCon.Click += new System.EventHandler(this.deleteButtonCon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 490);
            this.Controls.Add(this.deletePanel);
            this.Controls.Add(this.tableNameHeader);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tableNameHeader;
        private System.Windows.Forms.Panel deletePanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.TextBox airportID;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox airportName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label deletePromptLabel;
        private System.Windows.Forms.Button deleteButtonCon;
    }
}