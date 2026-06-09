namespace Distance_converter
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
            this.InputTxt = new System.Windows.Forms.TextBox();
            this.FromList = new System.Windows.Forms.ListBox();
            this.ToList = new System.Windows.Forms.ListBox();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.InputTxt2 = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputTxt
            // 
            this.InputTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputTxt.Location = new System.Drawing.Point(499, 28);
            this.InputTxt.Name = "InputTxt";
            this.InputTxt.Size = new System.Drawing.Size(100, 20);
            this.InputTxt.TabIndex = 0;
            // 
            // FromList
            // 
            this.FromList.FormattingEnabled = true;
            this.FromList.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.FromList.Location = new System.Drawing.Point(215, 101);
            this.FromList.Name = "FromList";
            this.FromList.Size = new System.Drawing.Size(120, 95);
            this.FromList.TabIndex = 1;
            // 
            // ToList
            // 
            this.ToList.FormattingEnabled = true;
            this.ToList.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.ToList.Location = new System.Drawing.Point(499, 101);
            this.ToList.Name = "ToList";
            this.ToList.Size = new System.Drawing.Size(120, 95);
            this.ToList.TabIndex = 2;
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Location = new System.Drawing.Point(283, 377);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(75, 23);
            this.ConvertBtn.TabIndex = 3;
            this.ConvertBtn.Text = "Convert";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // InputTxt2
            // 
            this.InputTxt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputTxt2.Location = new System.Drawing.Point(499, 258);
            this.InputTxt2.Name = "InputTxt2";
            this.InputTxt2.Size = new System.Drawing.Size(100, 20);
            this.InputTxt2.TabIndex = 5;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(499, 377);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter a distance to convert:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter a distance to convert:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "To";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.InputTxt2);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.ToList);
            this.Controls.Add(this.FromList);
            this.Controls.Add(this.InputTxt);
            this.Name = "Form1";
            this.Text = "Distance Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTxt;
        private System.Windows.Forms.ListBox FromList;
        private System.Windows.Forms.ListBox ToList;
        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.TextBox InputTxt2;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

