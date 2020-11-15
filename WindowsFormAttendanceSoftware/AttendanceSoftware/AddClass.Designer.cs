
namespace WindowsFormsApp1
{
    partial class AddClass
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
            this.className_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.ClassNameTxt = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // className_txt
            // 
            this.className_txt.Location = new System.Drawing.Point(111, 58);
            this.className_txt.Name = "className_txt";
            this.className_txt.Size = new System.Drawing.Size(216, 23);
            this.className_txt.TabIndex = 0;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(252, 87);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Accept";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // ClassNameTxt
            // 
            this.ClassNameTxt.AutoSize = true;
            this.ClassNameTxt.Location = new System.Drawing.Point(111, 36);
            this.ClassNameTxt.Name = "ClassNameTxt";
            this.ClassNameTxt.Size = new System.Drawing.Size(78, 19);
            this.ClassNameTxt.TabIndex = 2;
            this.ClassNameTxt.Text = "Class Name";
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 187);
            this.Controls.Add(this.ClassNameTxt);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.className_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Ckass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox className_txt;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel ClassNameTxt;
    }
}