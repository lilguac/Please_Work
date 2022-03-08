namespace FinalProject
{
    partial class ManagePhones
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
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.txtNeighbor = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(147, 62);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(263, 22);
            this.txtSerial.TabIndex = 0;
            // 
            // txtNeighbor
            // 
            this.txtNeighbor.Location = new System.Drawing.Point(147, 114);
            this.txtNeighbor.Name = "txtNeighbor";
            this.txtNeighbor.Size = new System.Drawing.Size(263, 22);
            this.txtNeighbor.TabIndex = 1;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(147, 167);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(263, 22);
            this.txtDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phone Serial #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Neighbor Assigned";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date Issued";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(257, 234);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(153, 53);
            this.btnAssign.TabIndex = 6;
            this.btnAssign.Text = "Assign Phone";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(15, 234);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 53);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ManagePhones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 337);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtNeighbor);
            this.Controls.Add(this.txtSerial);
            this.Name = "ManagePhones";
            this.Text = "ManagePhones";
            this.Load += new System.EventHandler(this.ManagePhones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.TextBox txtNeighbor;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnExit;
    }
}