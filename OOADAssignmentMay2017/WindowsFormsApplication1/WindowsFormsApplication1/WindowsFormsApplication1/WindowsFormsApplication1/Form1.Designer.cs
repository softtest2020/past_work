namespace WindowsFormsApplication1
{
    partial class frmCarassociation
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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.btnRenewMember = new System.Windows.Forms.Button();
            this.btnEditMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIc = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblMembership = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCarregnum = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxIc = new System.Windows.Forms.TextBox();
            this.tbxDob = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblinstruction = new System.Windows.Forms.Label();
            this.tbxMembership = new System.Windows.Forms.TextBox();
            this.btnRenew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.tbxCarRegNum = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.lblSearchIC = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.rbnOneYearMembership = new System.Windows.Forms.RadioButton();
            this.rbnFiveYearMembership = new System.Windows.Forms.RadioButton();
            this.lblTypeOfMembership = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1193, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(24, 578);
            this.vScrollBar1.TabIndex = 0;
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Location = new System.Drawing.Point(16, 12);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(161, 23);
            this.btnSearchMember.TabIndex = 1;
            this.btnSearchMember.Text = "Search Member\'s Details";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // btnRenewMember
            // 
            this.btnRenewMember.Location = new System.Drawing.Point(16, 41);
            this.btnRenewMember.Name = "btnRenewMember";
            this.btnRenewMember.Size = new System.Drawing.Size(161, 23);
            this.btnRenewMember.TabIndex = 2;
            this.btnRenewMember.Text = "Renew Member\'s Membership";
            this.btnRenewMember.UseVisualStyleBackColor = true;
            this.btnRenewMember.Click += new System.EventHandler(this.btnRenewMember_Click);
            // 
            // btnEditMember
            // 
            this.btnEditMember.Location = new System.Drawing.Point(16, 70);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(161, 23);
            this.btnEditMember.TabIndex = 3;
            this.btnEditMember.Text = "Edit Member\'s Details";
            this.btnEditMember.UseVisualStyleBackColor = true;
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(224, 12);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(161, 23);
            this.btnAddMember.TabIndex = 4;
            this.btnAddMember.Text = "Add New Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(224, 41);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name                       : ";
            // 
            // lblIc
            // 
            this.lblIc.AutoSize = true;
            this.lblIc.Location = new System.Drawing.Point(15, 38);
            this.lblIc.Name = "lblIc";
            this.lblIc.Size = new System.Drawing.Size(110, 13);
            this.lblIc.TabIndex = 7;
            this.lblIc.Text = "I/C Number              : ";
            this.lblIc.Click += new System.EventHandler(this.lblIc_Click);
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(15, 64);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(111, 13);
            this.lblDob.TabIndex = 8;
            this.lblDob.Text = "Date of Birth             : ";
            // 
            // lblMembership
            // 
            this.lblMembership.AutoSize = true;
            this.lblMembership.Location = new System.Drawing.Point(15, 90);
            this.lblMembership.Name = "lblMembership";
            this.lblMembership.Size = new System.Drawing.Size(111, 13);
            this.lblMembership.TabIndex = 9;
            this.lblMembership.Text = "Date of Membership : ";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(15, 116);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(111, 13);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Phone Number         : ";
            // 
            // lblCarregnum
            // 
            this.lblCarregnum.AutoSize = true;
            this.lblCarregnum.Location = new System.Drawing.Point(15, 142);
            this.lblCarregnum.Name = "lblCarregnum";
            this.lblCarregnum.Size = new System.Drawing.Size(111, 13);
            this.lblCarregnum.TabIndex = 11;
            this.lblCarregnum.Text = "Car Registration No. : ";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(15, 168);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(110, 13);
            this.lblModel.TabIndex = 12;
            this.lblModel.Text = "Car\'s Model              : ";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(15, 194);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(111, 13);
            this.lblYear.TabIndex = 13;
            this.lblYear.Text = "Year of Car               : ";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(129, 9);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(217, 20);
            this.tbxName.TabIndex = 14;
            // 
            // tbxIc
            // 
            this.tbxIc.Location = new System.Drawing.Point(129, 35);
            this.tbxIc.Name = "tbxIc";
            this.tbxIc.Size = new System.Drawing.Size(217, 20);
            this.tbxIc.TabIndex = 15;
            // 
            // tbxDob
            // 
            this.tbxDob.Location = new System.Drawing.Point(129, 61);
            this.tbxDob.Name = "tbxDob";
            this.tbxDob.Size = new System.Drawing.Size(217, 20);
            this.tbxDob.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTypeOfMembership);
            this.panel1.Controls.Add(this.rbnOneYearMembership);
            this.panel1.Controls.Add(this.rbnFiveYearMembership);
            this.panel1.Controls.Add(this.lblinstruction);
            this.panel1.Controls.Add(this.tbxMembership);
            this.panel1.Controls.Add(this.btnRenew);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.tbxYear);
            this.panel1.Controls.Add(this.tbxModel);
            this.panel1.Controls.Add(this.tbxCarRegNum);
            this.panel1.Controls.Add(this.tbxPhone);
            this.panel1.Controls.Add(this.tbxIc);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Controls.Add(this.lblModel);
            this.panel1.Controls.Add(this.tbxName);
            this.panel1.Controls.Add(this.lblCarregnum);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.tbxDob);
            this.panel1.Controls.Add(this.lblMembership);
            this.panel1.Controls.Add(this.lblDob);
            this.panel1.Controls.Add(this.lblIc);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(16, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 303);
            this.panel1.TabIndex = 22;
            this.panel1.Visible = false;
            this.panel1.VisibleChanged += new System.EventHandler(this.frmCarassociation_Load);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblinstruction
            // 
            this.lblinstruction.AutoSize = true;
            this.lblinstruction.Location = new System.Drawing.Point(15, 217);
            this.lblinstruction.Name = "lblinstruction";
            this.lblinstruction.Size = new System.Drawing.Size(112, 13);
            this.lblinstruction.TabIndex = 28;
            this.lblinstruction.Text = "Instructions               : ";
            // 
            // tbxMembership
            // 
            this.tbxMembership.Location = new System.Drawing.Point(129, 87);
            this.tbxMembership.Name = "tbxMembership";
            this.tbxMembership.Size = new System.Drawing.Size(217, 20);
            this.tbxMembership.TabIndex = 27;
            // 
            // btnRenew
            // 
            this.btnRenew.Location = new System.Drawing.Point(369, 137);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(75, 23);
            this.btnRenew.TabIndex = 23;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(369, 163);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(369, 189);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(129, 191);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(217, 20);
            this.tbxYear.TabIndex = 21;
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(129, 165);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(217, 20);
            this.tbxModel.TabIndex = 20;
            // 
            // tbxCarRegNum
            // 
            this.tbxCarRegNum.Location = new System.Drawing.Point(129, 139);
            this.tbxCarRegNum.Name = "tbxCarRegNum";
            this.tbxCarRegNum.Size = new System.Drawing.Size(217, 20);
            this.tbxCarRegNum.TabIndex = 19;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(129, 113);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(217, 20);
            this.tbxPhone.TabIndex = 18;
            // 
            // lblSearchIC
            // 
            this.lblSearchIC.AutoSize = true;
            this.lblSearchIC.Location = new System.Drawing.Point(3, 10);
            this.lblSearchIC.Name = "lblSearchIC";
            this.lblSearchIC.Size = new System.Drawing.Size(71, 13);
            this.lblSearchIC.TabIndex = 23;
            this.lblSearchIC.Text = "I/C Number : ";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(86, 7);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(177, 20);
            this.tbxSearch.TabIndex = 24;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(269, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.tbxSearch);
            this.panel2.Controls.Add(this.lblSearchIC);
            this.panel2.Location = new System.Drawing.Point(16, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 33);
            this.panel2.TabIndex = 26;
            this.panel2.Visible = false;
            this.panel2.VisibleChanged += new System.EventHandler(this.frmCarassociation_Load);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(224, 70);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(161, 23);
            this.btnQuit.TabIndex = 27;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // rbnOneYearMembership
            // 
            this.rbnOneYearMembership.AutoSize = true;
            this.rbnOneYearMembership.Location = new System.Drawing.Point(129, 256);
            this.rbnOneYearMembership.Name = "rbnOneYearMembership";
            this.rbnOneYearMembership.Size = new System.Drawing.Size(130, 17);
            this.rbnOneYearMembership.TabIndex = 28;
            this.rbnOneYearMembership.TabStop = true;
            this.rbnOneYearMembership.Text = "One Year Membership";
            this.rbnOneYearMembership.UseVisualStyleBackColor = true;
            // 
            // rbnFiveYearMembership
            // 
            this.rbnFiveYearMembership.AutoSize = true;
            this.rbnFiveYearMembership.Location = new System.Drawing.Point(129, 279);
            this.rbnFiveYearMembership.Name = "rbnFiveYearMembership";
            this.rbnFiveYearMembership.Size = new System.Drawing.Size(130, 17);
            this.rbnFiveYearMembership.TabIndex = 29;
            this.rbnFiveYearMembership.TabStop = true;
            this.rbnFiveYearMembership.Text = "Five Year Membership";
            this.rbnFiveYearMembership.UseVisualStyleBackColor = true;
            // 
            // lblTypeOfMembership
            // 
            this.lblTypeOfMembership.AutoSize = true;
            this.lblTypeOfMembership.Location = new System.Drawing.Point(15, 240);
            this.lblTypeOfMembership.Name = "lblTypeOfMembership";
            this.lblTypeOfMembership.Size = new System.Drawing.Size(111, 13);
            this.lblTypeOfMembership.TabIndex = 28;
            this.lblTypeOfMembership.Text = "Type Of Membership: ";
            // 
            // frmCarassociation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.btnEditMember);
            this.Controls.Add(this.btnRenewMember);
            this.Controls.Add(this.btnSearchMember);
            this.Controls.Add(this.vScrollBar1);
            this.Name = "frmCarassociation";
            this.Text = "Car Association";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCarassociation_FormClosed);
            this.Load += new System.EventHandler(this.frmCarassociation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Button btnRenewMember;
        private System.Windows.Forms.Button btnEditMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIc;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblMembership;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCarregnum;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxIc;
        private System.Windows.Forms.TextBox tbxDob;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.TextBox tbxCarRegNum;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSearchIC;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxMembership;
        private System.Windows.Forms.Label lblinstruction;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.RadioButton rbnOneYearMembership;
        private System.Windows.Forms.RadioButton rbnFiveYearMembership;
        private System.Windows.Forms.Label lblTypeOfMembership;
    }
}

