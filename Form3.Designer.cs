namespace Milestone_4
{
    partial class Form3
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
            this.invGroupBox = new System.Windows.Forms.GroupBox();
            this.InvXboxLabel = new System.Windows.Forms.Label();
            this.invPSLabel = new System.Windows.Forms.Label();
            this.QuantRetLabel = new System.Windows.Forms.Label();
            this.InvTextBox = new System.Windows.Forms.TextBox();
            this.XboxRetBut = new System.Windows.Forms.Button();
            this.ReturnPSBut = new System.Windows.Forms.Button();
            this.ExitButtonShop = new System.Windows.Forms.Button();
            this.invGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // invGroupBox
            // 
            this.invGroupBox.Controls.Add(this.invPSLabel);
            this.invGroupBox.Controls.Add(this.InvXboxLabel);
            this.invGroupBox.Location = new System.Drawing.Point(12, 0);
            this.invGroupBox.Name = "invGroupBox";
            this.invGroupBox.Size = new System.Drawing.Size(578, 360);
            this.invGroupBox.TabIndex = 0;
            this.invGroupBox.TabStop = false;
            this.invGroupBox.Text = "Inventory";
            // 
            // InvXboxLabel
            // 
            this.InvXboxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InvXboxLabel.Location = new System.Drawing.Point(34, 43);
            this.InvXboxLabel.Name = "InvXboxLabel";
            this.InvXboxLabel.Size = new System.Drawing.Size(237, 299);
            this.InvXboxLabel.TabIndex = 6;
            // 
            // invPSLabel
            // 
            this.invPSLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.invPSLabel.Location = new System.Drawing.Point(304, 43);
            this.invPSLabel.Name = "invPSLabel";
            this.invPSLabel.Size = new System.Drawing.Size(237, 299);
            this.invPSLabel.TabIndex = 7;
            // 
            // QuantRetLabel
            // 
            this.QuantRetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantRetLabel.Location = new System.Drawing.Point(118, 376);
            this.QuantRetLabel.Name = "QuantRetLabel";
            this.QuantRetLabel.Size = new System.Drawing.Size(144, 55);
            this.QuantRetLabel.TabIndex = 3;
            this.QuantRetLabel.Text = "Quantity:";
            // 
            // InvTextBox
            // 
            this.InvTextBox.AcceptsReturn = true;
            this.InvTextBox.Location = new System.Drawing.Point(248, 376);
            this.InvTextBox.Multiline = true;
            this.InvTextBox.Name = "InvTextBox";
            this.InvTextBox.Size = new System.Drawing.Size(205, 31);
            this.InvTextBox.TabIndex = 4;
            // 
            // XboxRetBut
            // 
            this.XboxRetBut.Location = new System.Drawing.Point(85, 434);
            this.XboxRetBut.Name = "XboxRetBut";
            this.XboxRetBut.Size = new System.Drawing.Size(198, 76);
            this.XboxRetBut.TabIndex = 5;
            this.XboxRetBut.Text = "Return Xbox";
            this.XboxRetBut.UseVisualStyleBackColor = true;
            // 
            // ReturnPSBut
            // 
            this.ReturnPSBut.Location = new System.Drawing.Point(334, 434);
            this.ReturnPSBut.Name = "ReturnPSBut";
            this.ReturnPSBut.Size = new System.Drawing.Size(198, 76);
            this.ReturnPSBut.TabIndex = 6;
            this.ReturnPSBut.Text = "Return Playstation";
            this.ReturnPSBut.UseVisualStyleBackColor = true;
            // 
            // ExitButtonShop
            // 
            this.ExitButtonShop.Location = new System.Drawing.Point(208, 516);
            this.ExitButtonShop.Name = "ExitButtonShop";
            this.ExitButtonShop.Size = new System.Drawing.Size(198, 76);
            this.ExitButtonShop.TabIndex = 7;
            this.ExitButtonShop.Text = "Close Inventory";
            this.ExitButtonShop.UseVisualStyleBackColor = true;
            this.ExitButtonShop.Click += new System.EventHandler(this.ExitButtonShop_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 607);
            this.Controls.Add(this.ExitButtonShop);
            this.Controls.Add(this.ReturnPSBut);
            this.Controls.Add(this.XboxRetBut);
            this.Controls.Add(this.InvTextBox);
            this.Controls.Add(this.QuantRetLabel);
            this.Controls.Add(this.invGroupBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.invGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox invGroupBox;
        private System.Windows.Forms.Label invPSLabel;
        private System.Windows.Forms.Label InvXboxLabel;
        private System.Windows.Forms.Label QuantRetLabel;
        private System.Windows.Forms.TextBox InvTextBox;
        private System.Windows.Forms.Button XboxRetBut;
        private System.Windows.Forms.Button ReturnPSBut;
        private System.Windows.Forms.Button ExitButtonShop;
    }
}