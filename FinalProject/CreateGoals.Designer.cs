namespace FinalProject
{
    partial class CreateGoals
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
            this.txtGoal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtGoals = new System.Windows.Forms.TextBox();
            this.btnGoal = new System.Windows.Forms.Button();
            this.txtRewards = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmbRewards = new System.Windows.Forms.ComboBox();
            this.btnReward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGoal
            // 
            this.txtGoal.Location = new System.Drawing.Point(30, 59);
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Size = new System.Drawing.Size(255, 22);
            this.txtGoal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Goal for Neighbor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reward for Goal Completion";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(409, 497);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(172, 52);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Submit Goal(s) and Reward(s)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtGoals
            // 
            this.txtGoals.Location = new System.Drawing.Point(330, 21);
            this.txtGoals.Multiline = true;
            this.txtGoals.Name = "txtGoals";
            this.txtGoals.Size = new System.Drawing.Size(251, 213);
            this.txtGoals.TabIndex = 6;
            this.txtGoals.TextChanged += new System.EventHandler(this.txtGoals_TextChanged);
            // 
            // btnGoal
            // 
            this.btnGoal.Location = new System.Drawing.Point(64, 106);
            this.btnGoal.Name = "btnGoal";
            this.btnGoal.Size = new System.Drawing.Size(172, 52);
            this.btnGoal.TabIndex = 7;
            this.btnGoal.Text = "Add Goal";
            this.btnGoal.UseVisualStyleBackColor = true;
            this.btnGoal.Click += new System.EventHandler(this.btnGoal_Click);
            // 
            // txtRewards
            // 
            this.txtRewards.Location = new System.Drawing.Point(330, 267);
            this.txtRewards.Multiline = true;
            this.txtRewards.Name = "txtRewards";
            this.txtRewards.Size = new System.Drawing.Size(251, 213);
            this.txtRewards.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 497);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 52);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmbRewards
            // 
            this.cmbRewards.FormattingEnabled = true;
            this.cmbRewards.Location = new System.Drawing.Point(52, 297);
            this.cmbRewards.Name = "cmbRewards";
            this.cmbRewards.Size = new System.Drawing.Size(121, 24);
            this.cmbRewards.TabIndex = 10;
            // 
            // btnReward
            // 
            this.btnReward.Location = new System.Drawing.Point(64, 367);
            this.btnReward.Name = "btnReward";
            this.btnReward.Size = new System.Drawing.Size(172, 52);
            this.btnReward.TabIndex = 11;
            this.btnReward.Text = "Add Reward";
            this.btnReward.UseVisualStyleBackColor = true;
            this.btnReward.Click += new System.EventHandler(this.btnReward_Click);
            // 
            // CreateGoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 561);
            this.Controls.Add(this.btnReward);
            this.Controls.Add(this.cmbRewards);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtRewards);
            this.Controls.Add(this.btnGoal);
            this.Controls.Add(this.txtGoals);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGoal);
            this.Name = "CreateGoals";
            this.Text = "CreateGoals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGoal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtGoals;
        private System.Windows.Forms.Button btnGoal;
        private System.Windows.Forms.TextBox txtRewards;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmbRewards;
        private System.Windows.Forms.Button btnReward;
    }
}