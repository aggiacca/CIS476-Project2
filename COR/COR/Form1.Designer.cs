namespace COR1
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
            this.InputUnit = new System.Windows.Forms.TextBox();
            this.KiloLabel = new System.Windows.Forms.Label();
            this.TargetUnitBox = new System.Windows.Forms.ComboBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputUnit
            // 
            this.InputUnit.Location = new System.Drawing.Point(12, 12);
            this.InputUnit.Name = "InputUnit";
            this.InputUnit.Size = new System.Drawing.Size(100, 20);
            this.InputUnit.TabIndex = 0;
            // 
            // KiloLabel
            // 
            this.KiloLabel.AutoSize = true;
            this.KiloLabel.Location = new System.Drawing.Point(118, 15);
            this.KiloLabel.Name = "KiloLabel";
            this.KiloLabel.Size = new System.Drawing.Size(50, 13);
            this.KiloLabel.TabIndex = 2;
            this.KiloLabel.Text = "Kilometer";
            this.KiloLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // TargetUnitBox
            // 
            this.TargetUnitBox.FormattingEnabled = true;
            this.TargetUnitBox.Items.AddRange(new object[] {
            "Yard",
            "Foot"});
            this.TargetUnitBox.Location = new System.Drawing.Point(121, 61);
            this.TargetUnitBox.Name = "TargetUnitBox";
            this.TargetUnitBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TargetUnitBox.Size = new System.Drawing.Size(121, 21);
            this.TargetUnitBox.TabIndex = 3;
            this.TargetUnitBox.Text = "Mile";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(12, 115);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(75, 23);
            this.CalculateBtn.TabIndex = 4;
            this.CalculateBtn.Text = "Convert";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(12, 62);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(100, 20);
            this.OutputBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 228);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.TargetUnitBox);
            this.Controls.Add(this.KiloLabel);
            this.Controls.Add(this.InputUnit);
            this.Name = "Form1";
            this.Text = "Length converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputUnit;
        private System.Windows.Forms.Label KiloLabel;
        private System.Windows.Forms.ComboBox TargetUnitBox;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.TextBox OutputBox;
    }
}

