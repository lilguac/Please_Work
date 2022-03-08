
namespace FinalProject
{
    partial class NeighborMainForm
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
            this.btnGoals = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoals
            // 
            this.btnGoals.Location = new System.Drawing.Point(12, 39);
            this.btnGoals.Name = "btnGoals";
            this.btnGoals.Size = new System.Drawing.Size(320, 55);
            this.btnGoals.TabIndex = 0;
            this.btnGoals.Text = "View My Goals";
            this.btnGoals.UseVisualStyleBackColor = true;
            this.btnGoals.Click += new System.EventHandler(this.btnGoals_Click);
            // 
            // btnContact
            // 
            this.btnContact.Location = new System.Drawing.Point(12, 112);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(320, 55);
            this.btnContact.TabIndex = 1;
            this.btnContact.Text = "Contact Us";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnLogOff
            // 
            this.btnLogOff.Location = new System.Drawing.Point(12, 251);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(191, 55);
            this.btnLogOff.TabIndex = 2;
            this.btnLogOff.Text = "Log Off";
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // NeighborMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 374);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.btnGoals);
            this.Name = "NeighborMainForm";
            this.Text = "NeighborMainForm";
            this.Load += new System.EventHandler(this.NeighborMainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoals;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnLogOff;
    }
}