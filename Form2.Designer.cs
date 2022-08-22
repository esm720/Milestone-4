namespace Milestone_4
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.XboxPurBut = new System.Windows.Forms.Button();
            this.PSPurBut = new System.Windows.Forms.Button();
            this.QuantPurchLabel = new System.Windows.Forms.Label();
            this.shopTextInp = new System.Windows.Forms.TextBox();
            this.ExitButtonShop = new System.Windows.Forms.Button();
            this.ShopXboxLabel = new System.Windows.Forms.Label();
            this.productGroupBox = new System.Windows.Forms.GroupBox();
            this.ShowPSLabel = new System.Windows.Forms.Label();
            this.ReturnPSBut = new System.Windows.Forms.Button();
            this.XboxRetBut = new System.Windows.Forms.Button();
            this.InvTextBox = new System.Windows.Forms.TextBox();
            this.QuantRetLabel = new System.Windows.Forms.Label();
            this.invGroupBox = new System.Windows.Forms.GroupBox();
            this.invPSLabel = new System.Windows.Forms.Label();
            this.InvXboxLabel = new System.Windows.Forms.Label();
            this.RestockButton = new System.Windows.Forms.Button();
            this.productGroupBox.SuspendLayout();
            this.invGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // XboxPurBut
            // 
            this.XboxPurBut.BackColor = System.Drawing.Color.DarkGray;
            this.XboxPurBut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.XboxPurBut.Location = new System.Drawing.Point(63, 479);
            this.XboxPurBut.Name = "XboxPurBut";
            this.XboxPurBut.Size = new System.Drawing.Size(198, 76);
            this.XboxPurBut.TabIndex = 0;
            this.XboxPurBut.Text = "Purchase Xbox";
            this.XboxPurBut.UseVisualStyleBackColor = false;
            this.XboxPurBut.Click += new System.EventHandler(this.XboxPurBut_Click);
            // 
            // PSPurBut
            // 
            this.PSPurBut.BackColor = System.Drawing.Color.DarkGray;
            this.PSPurBut.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PSPurBut.Location = new System.Drawing.Point(323, 479);
            this.PSPurBut.Name = "PSPurBut";
            this.PSPurBut.Size = new System.Drawing.Size(198, 76);
            this.PSPurBut.TabIndex = 1;
            this.PSPurBut.Text = "Purchase Playstation";
            this.PSPurBut.UseVisualStyleBackColor = false;
            this.PSPurBut.Click += new System.EventHandler(this.PSPurBut_Click);
            // 
            // QuantPurchLabel
            // 
            this.QuantPurchLabel.Font = new System.Drawing.Font("MS Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantPurchLabel.Location = new System.Drawing.Point(117, 412);
            this.QuantPurchLabel.Name = "QuantPurchLabel";
            this.QuantPurchLabel.Size = new System.Drawing.Size(144, 55);
            this.QuantPurchLabel.TabIndex = 2;
            this.QuantPurchLabel.Text = "Quantity:";
            // 
            // shopTextInp
            // 
            this.shopTextInp.Location = new System.Drawing.Point(251, 414);
            this.shopTextInp.Multiline = true;
            this.shopTextInp.Name = "shopTextInp";
            this.shopTextInp.Size = new System.Drawing.Size(205, 31);
            this.shopTextInp.TabIndex = 3;
            // 
            // ExitButtonShop
            // 
            this.ExitButtonShop.BackColor = System.Drawing.Color.DarkGray;
            this.ExitButtonShop.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExitButtonShop.Location = new System.Drawing.Point(785, 593);
            this.ExitButtonShop.Name = "ExitButtonShop";
            this.ExitButtonShop.Size = new System.Drawing.Size(198, 76);
            this.ExitButtonShop.TabIndex = 4;
            this.ExitButtonShop.Text = "Close Shop";
            this.ExitButtonShop.UseVisualStyleBackColor = false;
            this.ExitButtonShop.Click += new System.EventHandler(this.ExitButtonShop_Click);
            // 
            // ShopXboxLabel
            // 
            this.ShopXboxLabel.BackColor = System.Drawing.Color.LightGray;
            this.ShopXboxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ShopXboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopXboxLabel.Location = new System.Drawing.Point(29, 27);
            this.ShopXboxLabel.Name = "ShopXboxLabel";
            this.ShopXboxLabel.Size = new System.Drawing.Size(237, 347);
            this.ShopXboxLabel.TabIndex = 5;
            // 
            // productGroupBox
            // 
            this.productGroupBox.BackColor = System.Drawing.Color.Gray;
            this.productGroupBox.Controls.Add(this.ShowPSLabel);
            this.productGroupBox.Controls.Add(this.ShopXboxLabel);
            this.productGroupBox.Location = new System.Drawing.Point(12, 12);
            this.productGroupBox.Name = "productGroupBox";
            this.productGroupBox.Size = new System.Drawing.Size(559, 388);
            this.productGroupBox.TabIndex = 6;
            this.productGroupBox.TabStop = false;
            this.productGroupBox.Text = "Products";
            // 
            // ShowPSLabel
            // 
            this.ShowPSLabel.BackColor = System.Drawing.Color.LightGray;
            this.ShowPSLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ShowPSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPSLabel.Location = new System.Drawing.Point(291, 27);
            this.ShowPSLabel.Name = "ShowPSLabel";
            this.ShowPSLabel.Size = new System.Drawing.Size(237, 347);
            this.ShowPSLabel.TabIndex = 6;
            // 
            // ReturnPSBut
            // 
            this.ReturnPSBut.BackColor = System.Drawing.Color.DarkGray;
            this.ReturnPSBut.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ReturnPSBut.Location = new System.Drawing.Point(914, 479);
            this.ReturnPSBut.Name = "ReturnPSBut";
            this.ReturnPSBut.Size = new System.Drawing.Size(198, 76);
            this.ReturnPSBut.TabIndex = 12;
            this.ReturnPSBut.Text = "Return Playstation";
            this.ReturnPSBut.UseVisualStyleBackColor = false;
            this.ReturnPSBut.Click += new System.EventHandler(this.ReturnPSBut_Click);
            // 
            // XboxRetBut
            // 
            this.XboxRetBut.BackColor = System.Drawing.Color.DarkGray;
            this.XboxRetBut.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.XboxRetBut.Location = new System.Drawing.Point(666, 479);
            this.XboxRetBut.Name = "XboxRetBut";
            this.XboxRetBut.Size = new System.Drawing.Size(198, 76);
            this.XboxRetBut.TabIndex = 11;
            this.XboxRetBut.Text = "Return Xbox";
            this.XboxRetBut.UseVisualStyleBackColor = false;
            this.XboxRetBut.Click += new System.EventHandler(this.XboxRetBut_Click);
            // 
            // InvTextBox
            // 
            this.InvTextBox.AcceptsReturn = true;
            this.InvTextBox.Location = new System.Drawing.Point(828, 414);
            this.InvTextBox.Multiline = true;
            this.InvTextBox.Name = "InvTextBox";
            this.InvTextBox.Size = new System.Drawing.Size(205, 31);
            this.InvTextBox.TabIndex = 10;
            // 
            // QuantRetLabel
            // 
            this.QuantRetLabel.Font = new System.Drawing.Font("MS Gothic", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantRetLabel.Location = new System.Drawing.Point(698, 412);
            this.QuantRetLabel.Name = "QuantRetLabel";
            this.QuantRetLabel.Size = new System.Drawing.Size(144, 55);
            this.QuantRetLabel.TabIndex = 9;
            this.QuantRetLabel.Text = "Quantity:";
            // 
            // invGroupBox
            // 
            this.invGroupBox.BackColor = System.Drawing.Color.Gray;
            this.invGroupBox.Controls.Add(this.invPSLabel);
            this.invGroupBox.Controls.Add(this.InvXboxLabel);
            this.invGroupBox.Location = new System.Drawing.Point(593, 12);
            this.invGroupBox.Name = "invGroupBox";
            this.invGroupBox.Size = new System.Drawing.Size(578, 388);
            this.invGroupBox.TabIndex = 8;
            this.invGroupBox.TabStop = false;
            this.invGroupBox.Text = "Inventory";
            // 
            // invPSLabel
            // 
            this.invPSLabel.BackColor = System.Drawing.Color.LightGray;
            this.invPSLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.invPSLabel.Location = new System.Drawing.Point(304, 27);
            this.invPSLabel.Name = "invPSLabel";
            this.invPSLabel.Size = new System.Drawing.Size(237, 347);
            this.invPSLabel.TabIndex = 7;
            // 
            // InvXboxLabel
            // 
            this.InvXboxLabel.BackColor = System.Drawing.Color.LightGray;
            this.InvXboxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InvXboxLabel.Location = new System.Drawing.Point(34, 27);
            this.InvXboxLabel.Name = "InvXboxLabel";
            this.InvXboxLabel.Size = new System.Drawing.Size(237, 347);
            this.InvXboxLabel.TabIndex = 6;
            // 
            // RestockButton
            // 
            this.RestockButton.BackColor = System.Drawing.Color.DarkGray;
            this.RestockButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RestockButton.Location = new System.Drawing.Point(191, 593);
            this.RestockButton.Name = "RestockButton";
            this.RestockButton.Size = new System.Drawing.Size(198, 76);
            this.RestockButton.TabIndex = 13;
            this.RestockButton.Text = "Restock Items";
            this.RestockButton.UseVisualStyleBackColor = false;
            this.RestockButton.Click += new System.EventHandler(this.RestockButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1215, 710);
            this.Controls.Add(this.RestockButton);
            this.Controls.Add(this.ReturnPSBut);
            this.Controls.Add(this.XboxRetBut);
            this.Controls.Add(this.InvTextBox);
            this.Controls.Add(this.QuantRetLabel);
            this.Controls.Add(this.invGroupBox);
            this.Controls.Add(this.productGroupBox);
            this.Controls.Add(this.ExitButtonShop);
            this.Controls.Add(this.shopTextInp);
            this.Controls.Add(this.QuantPurchLabel);
            this.Controls.Add(this.PSPurBut);
            this.Controls.Add(this.XboxPurBut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.productGroupBox.ResumeLayout(false);
            this.invGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button XboxPurBut;
        private System.Windows.Forms.Button PSPurBut;
        private System.Windows.Forms.Label QuantPurchLabel;
        private System.Windows.Forms.TextBox shopTextInp;
        private System.Windows.Forms.Button ExitButtonShop;
        private System.Windows.Forms.Label ShopXboxLabel;
        private System.Windows.Forms.GroupBox productGroupBox;
        private System.Windows.Forms.Label ShowPSLabel;
        private System.Windows.Forms.Button ReturnPSBut;
        private System.Windows.Forms.Button XboxRetBut;
        private System.Windows.Forms.TextBox InvTextBox;
        private System.Windows.Forms.Label QuantRetLabel;
        private System.Windows.Forms.GroupBox invGroupBox;
        private System.Windows.Forms.Label invPSLabel;
        private System.Windows.Forms.Label InvXboxLabel;
        private System.Windows.Forms.Button RestockButton;
    }
}