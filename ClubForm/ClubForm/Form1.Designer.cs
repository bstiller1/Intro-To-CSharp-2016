namespace ClubForm
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
            this.lstBxEvents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxAddNew = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstBxEvents
            // 
            this.lstBxEvents.FormattingEnabled = true;
            this.lstBxEvents.Items.AddRange(new object[] {
            "Boat Tour",
            "Dance",
            "Dinner",
            "Hike",
            "Movie",
            "Picnic"});
            this.lstBxEvents.Location = new System.Drawing.Point(32, 38);
            this.lstBxEvents.Name = "lstBxEvents";
            this.lstBxEvents.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBxEvents.Size = new System.Drawing.Size(120, 95);
            this.lstBxEvents.TabIndex = 0;
            this.lstBxEvents.SelectedIndexChanged += new System.EventHandler(this.lstBxEvents_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Event(s):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add An Activity:";
            // 
            // txtBxAddNew
            // 
            this.txtBxAddNew.Location = new System.Drawing.Point(156, 148);
            this.txtBxAddNew.Name = "txtBxAddNew";
            this.txtBxAddNew.Size = new System.Drawing.Size(100, 20);
            this.txtBxAddNew.TabIndex = 3;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(156, 183);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "Add New One";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result:";
            // 
            // txtBxResult
            // 
            this.txtBxResult.Location = new System.Drawing.Point(1, 230);
            this.txtBxResult.Name = "txtBxResult";
            this.txtBxResult.Size = new System.Drawing.Size(283, 20);
            this.txtBxResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtBxResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtBxAddNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBxEvents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxAddNew;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxResult;
    }
}

