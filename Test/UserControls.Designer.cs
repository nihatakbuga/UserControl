namespace Test
{
    partial class NumericEntry
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
            this.btnTest = new System.Windows.Forms.Button();
            this.numericEntry1 = new UserControls.NumericEntry();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(281, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // numericEntry1
            // 
            this.numericEntry1.AllowNegative = false;
            this.numericEntry1.Caption = "Sayı";
            this.numericEntry1.CaptionLength = 100;
            this.numericEntry1.Enable = true;
            this.numericEntry1.Location = new System.Drawing.Point(12, 12);
            this.numericEntry1.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericEntry1.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericEntry1.Name = "numericEntry1";
            this.numericEntry1.Precesion = 3;
            this.numericEntry1.ReadOnly = false;
            this.numericEntry1.Required = false;
            this.numericEntry1.Size = new System.Drawing.Size(250, 30);
            this.numericEntry1.TabIndex = 0;
            // 
            // NumericEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 54);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.numericEntry1);
            this.Name = "NumericEntry";
            this.Text = "NumericEntryTest";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.NumericEntry numericEntry1;
        private System.Windows.Forms.Button btnTest;
    }
}

