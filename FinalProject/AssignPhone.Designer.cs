namespace FinalProject
{
    partial class AssignPhone
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtNeighbor = new System.Windows.Forms.TextBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(37, 210);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 53);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(279, 210);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(153, 53);
            this.btnAssign.TabIndex = 14;
            this.btnAssign.Text = "Assign Phone";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Date Issued";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Neighbor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Phone Serial #";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(169, 152);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(263, 22);
            this.txtDate.TabIndex = 10;
            // 
            // txtNeighbor
            // 
            this.txtNeighbor.Location = new System.Drawing.Point(169, 76);
            this.txtNeighbor.Name = "txtNeighbor";
            this.txtNeighbor.Size = new System.Drawing.Size(263, 22);
            this.txtNeighbor.TabIndex = 9;
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(169, 38);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(263, 22);
            this.txtSerial.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Neighbor ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(169, 114);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(263, 22);
            this.txtID.TabIndex = 16;
            // 
            // AssignPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 309);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtNeighbor);
            this.Controls.Add(this.txtSerial);
            this.Name = "AssignPhone";
            this.Text = "AssignPhone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtNeighbor;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
    }
}