namespace ColourPicker
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lboxList = new System.Windows.Forms.ListBox();
            this.clipboard = new System.Windows.Forms.Label();
            this.lboxTest = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Press Ctrl, Shift, Alt + F1 To copy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add a new code:";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(12, 104);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(162, 20);
            this.txtAdd.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(180, 101);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add!";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.ForeColor = System.Drawing.Color.Green;
            this.lblAdd.Location = new System.Drawing.Point(12, 137);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(0, 13);
            this.lblAdd.TabIndex = 6;
            // 
            // lboxList
            // 
            this.lboxList.FormattingEnabled = true;
            this.lboxList.Location = new System.Drawing.Point(10, 163);
            this.lboxList.Name = "lboxList";
            this.lboxList.Size = new System.Drawing.Size(242, 121);
            this.lboxList.TabIndex = 7;
            // 
            // clipboard
            // 
            this.clipboard.AutoSize = true;
            this.clipboard.Location = new System.Drawing.Point(12, 39);
            this.clipboard.Name = "clipboard";
            this.clipboard.Size = new System.Drawing.Size(0, 13);
            this.clipboard.TabIndex = 8;
            // 
            // lboxTest
            // 
            this.lboxTest.FormattingEnabled = true;
            this.lboxTest.Location = new System.Drawing.Point(10, 313);
            this.lboxTest.Name = "lboxTest";
            this.lboxTest.Size = new System.Drawing.Size(242, 69);
            this.lboxTest.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Unsaved Changes:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 396);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lboxTest);
            this.Controls.Add(this.clipboard);
            this.Controls.Add(this.lboxList);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Colour Picker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.ListBox lboxList;
        private System.Windows.Forms.Label clipboard;
        private System.Windows.Forms.ListBox lboxTest;
        private System.Windows.Forms.Label label3;
    }
}

