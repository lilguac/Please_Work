namespace FinalProject
{
    partial class CaseManagers
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnGoals = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(30, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(318, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtNotes
            // 
            this.txtNotes.AcceptsReturn = true;
            this.txtNotes.AcceptsTab = true;
            this.txtNotes.Location = new System.Drawing.Point(30, 245);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(318, 147);
            this.txtNotes.TabIndex = 1;
            this.txtNotes.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Notes on Session:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unique ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(30, 146);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(318, 22);
            this.txtID.TabIndex = 4;
            // 
            // btnNotes
            // 
            this.btnNotes.Location = new System.Drawing.Point(30, 418);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(151, 56);
            this.btnNotes.TabIndex = 6;
            this.btnNotes.Text = "Add Notes";
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // btnGoals
            // 
            this.btnGoals.Location = new System.Drawing.Point(197, 418);
            this.btnGoals.Name = "btnGoals";
            this.btnGoals.Size = new System.Drawing.Size(151, 56);
            this.btnGoals.TabIndex = 7;
            this.btnGoals.Text = "Create Goals";
            this.btnGoals.UseVisualStyleBackColor = true;
            this.btnGoals.Click += new System.EventHandler(this.btnGoals_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(30, 480);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(318, 56);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CaseManagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 549);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoals);
            this.Controls.Add(this.btnNotes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtName);
            this.Name = "CaseManagers";
            this.Text = "CaseManagers";
            this.Load += new System.EventHandler(this.CaseManagers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Button btnGoals;
        private System.Windows.Forms.Button btnExit;
    }
}