namespace FinalProject
{
    partial class EmployeeMainForm
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
            this.btnMaster = new System.Windows.Forms.Button();
            this.btnCase = new System.Windows.Forms.Button();
            this.btnLeader = new System.Windows.Forms.Button();
            this.btnPgrmMan = new System.Windows.Forms.Button();
            this.txtExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnPhone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMaster
            // 
            this.btnMaster.Location = new System.Drawing.Point(12, 12);
            this.btnMaster.Name = "btnMaster";
            this.btnMaster.Size = new System.Drawing.Size(202, 47);
            this.btnMaster.TabIndex = 0;
            this.btnMaster.Text = "Manage Roles";
            this.btnMaster.UseVisualStyleBackColor = true;
            this.btnMaster.Click += new System.EventHandler(this.btnMaster_Click);
            // 
            // btnCase
            // 
            this.btnCase.Location = new System.Drawing.Point(12, 79);
            this.btnCase.Name = "btnCase";
            this.btnCase.Size = new System.Drawing.Size(202, 47);
            this.btnCase.TabIndex = 1;
            this.btnCase.Text = "Case Managers";
            this.btnCase.UseVisualStyleBackColor = true;
            this.btnCase.Click += new System.EventHandler(this.btnCase_Click);
            // 
            // btnLeader
            // 
            this.btnLeader.Location = new System.Drawing.Point(253, 79);
            this.btnLeader.Name = "btnLeader";
            this.btnLeader.Size = new System.Drawing.Size(202, 47);
            this.btnLeader.TabIndex = 3;
            this.btnLeader.Text = "Manage Neighbors";
            this.btnLeader.UseVisualStyleBackColor = true;
            this.btnLeader.Click += new System.EventHandler(this.btnLeader_Click);
            // 
            // btnPgrmMan
            // 
            this.btnPgrmMan.Location = new System.Drawing.Point(253, 12);
            this.btnPgrmMan.Name = "btnPgrmMan";
            this.btnPgrmMan.Size = new System.Drawing.Size(202, 47);
            this.btnPgrmMan.TabIndex = 2;
            this.btnPgrmMan.Text = "Manage Classes/Events";
            this.btnPgrmMan.UseVisualStyleBackColor = true;
            this.btnPgrmMan.Click += new System.EventHandler(this.btnPgrmMan_Click);
            // 
            // txtExit
            // 
            this.txtExit.Location = new System.Drawing.Point(135, 310);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(202, 47);
            this.txtExit.TabIndex = 4;
            this.txtExit.Text = "Log off";
            this.txtExit.UseVisualStyleBackColor = true;
            this.txtExit.Click += new System.EventHandler(this.txtExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Program Leader:";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(12, 233);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(202, 47);
            this.btnCheckIn.TabIndex = 6;
            this.btnCheckIn.Text = "Check in Neighbor";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(253, 233);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(202, 47);
            this.btnInfo.TabIndex = 7;
            this.btnInfo.Text = "Neighbor Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPhone
            // 
            this.btnPhone.Location = new System.Drawing.Point(135, 142);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(202, 47);
            this.btnPhone.TabIndex = 8;
            this.btnPhone.Text = "Manage Phone Inventory";
            this.btnPhone.UseVisualStyleBackColor = true;
            this.btnPhone.Click += new System.EventHandler(this.btnPhone_Click);
            // 
            // EmployeeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 373);
            this.Controls.Add(this.btnPhone);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExit);
            this.Controls.Add(this.btnLeader);
            this.Controls.Add(this.btnPgrmMan);
            this.Controls.Add(this.btnCase);
            this.Controls.Add(this.btnMaster);
            this.Name = "EmployeeMainForm";
            this.Text = "EmployeeMainForm";
            this.Load += new System.EventHandler(this.EmployeeMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMaster;
        private System.Windows.Forms.Button btnCase;
        private System.Windows.Forms.Button btnLeader;
        private System.Windows.Forms.Button btnPgrmMan;
        private System.Windows.Forms.Button txtExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnPhone;
    }
}