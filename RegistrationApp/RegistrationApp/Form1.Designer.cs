namespace RegistrationApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckBxSwim = new System.Windows.Forms.CheckBox();
            this.ckBxSnorkel = new System.Windows.Forms.CheckBox();
            this.ckBxDive = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxResult = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radAdvanc = new System.Windows.Forms.RadioButton();
            this.radInterm = new System.Windows.Forms.RadioButton();
            this.radBeginner = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(209, 31);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(187, 20);
            this.txtBxName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Lesson:";
            // 
            // ckBxSwim
            // 
            this.ckBxSwim.AutoSize = true;
            this.ckBxSwim.Location = new System.Drawing.Point(74, 137);
            this.ckBxSwim.Name = "ckBxSwim";
            this.ckBxSwim.Size = new System.Drawing.Size(78, 17);
            this.ckBxSwim.TabIndex = 3;
            this.ckBxSwim.Text = "Swim - $50";
            this.ckBxSwim.UseVisualStyleBackColor = true;
            this.ckBxSwim.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // ckBxSnorkel
            // 
            this.ckBxSnorkel.AutoSize = true;
            this.ckBxSnorkel.Location = new System.Drawing.Point(74, 161);
            this.ckBxSnorkel.Name = "ckBxSnorkel";
            this.ckBxSnorkel.Size = new System.Drawing.Size(89, 17);
            this.ckBxSnorkel.TabIndex = 4;
            this.ckBxSnorkel.Text = "Snorkel - $25";
            this.ckBxSnorkel.UseVisualStyleBackColor = true;
            this.ckBxSnorkel.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // ckBxDive
            // 
            this.ckBxDive.AutoSize = true;
            this.ckBxDive.Location = new System.Drawing.Point(74, 185);
            this.ckBxDive.Name = "ckBxDive";
            this.ckBxDive.Size = new System.Drawing.Size(81, 17);
            this.ckBxDive.TabIndex = 5;
            this.ckBxDive.Text = "Dive - $100";
            this.ckBxDive.UseVisualStyleBackColor = true;
            this.ckBxDive.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Check All that Apply";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total";
            // 
            // txtBxResult
            // 
            this.txtBxResult.Location = new System.Drawing.Point(125, 281);
            this.txtBxResult.Name = "txtBxResult";
            this.txtBxResult.Size = new System.Drawing.Size(100, 20);
            this.txtBxResult.TabIndex = 8;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(330, 284);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 13);
            this.lblMsg.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radAdvanc);
            this.groupBox1.Controls.Add(this.radInterm);
            this.groupBox1.Controls.Add(this.radBeginner);
            this.groupBox1.Location = new System.Drawing.Point(296, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skill Level:";
            // 
            // radAdvanc
            // 
            this.radAdvanc.AutoSize = true;
            this.radAdvanc.Location = new System.Drawing.Point(7, 68);
            this.radAdvanc.Name = "radAdvanc";
            this.radAdvanc.Size = new System.Drawing.Size(74, 17);
            this.radAdvanc.TabIndex = 2;
            this.radAdvanc.TabStop = true;
            this.radAdvanc.Text = "Advanced";
            this.radAdvanc.UseVisualStyleBackColor = true;
            this.radAdvanc.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // radInterm
            // 
            this.radInterm.AutoSize = true;
            this.radInterm.Location = new System.Drawing.Point(7, 44);
            this.radInterm.Name = "radInterm";
            this.radInterm.Size = new System.Drawing.Size(83, 17);
            this.radInterm.TabIndex = 1;
            this.radInterm.TabStop = true;
            this.radInterm.Text = "Intermediate";
            this.radInterm.UseVisualStyleBackColor = true;
            this.radInterm.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // radBeginner
            // 
            this.radBeginner.AutoSize = true;
            this.radBeginner.Location = new System.Drawing.Point(7, 20);
            this.radBeginner.Name = "radBeginner";
            this.radBeginner.Size = new System.Drawing.Size(67, 17);
            this.radBeginner.TabIndex = 0;
            this.radBeginner.TabStop = true;
            this.radBeginner.Text = "Beginner";
            this.radBeginner.UseVisualStyleBackColor = true;
            this.radBeginner.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 463);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtBxResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckBxDive);
            this.Controls.Add(this.ckBxSnorkel);
            this.Controls.Add(this.ckBxSwim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Total:";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckBxSwim;
        private System.Windows.Forms.CheckBox ckBxSnorkel;
        private System.Windows.Forms.CheckBox ckBxDive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxResult;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radAdvanc;
        private System.Windows.Forms.RadioButton radInterm;
        private System.Windows.Forms.RadioButton radBeginner;
    }
}

