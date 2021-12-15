
namespace TrackerUI
{
    partial class CreatePrizeForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.placeNumberValue = new System.Windows.Forms.TextBox();
            this.placeNumberLabel = new System.Windows.Forms.Label();
            this.placeNameValue = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.priceAmountValue = new System.Windows.Forms.TextBox();
            this.priceAmountLabel = new System.Windows.Forms.Label();
            this.PricePercentage = new System.Windows.Forms.TextBox();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.orlabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.headerLabel.Location = new System.Drawing.Point(26, 21);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(209, 50);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            this.placeNumberValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNumberValue.Location = new System.Drawing.Point(275, 100);
            this.placeNumberValue.Margin = new System.Windows.Forms.Padding(4);
            this.placeNumberValue.Name = "placeNumberValue";
            this.placeNumberValue.Size = new System.Drawing.Size(217, 35);
            this.placeNumberValue.TabIndex = 15;
            this.placeNumberValue.TextChanged += new System.EventHandler(this.placeNumberValue_TextChanged);
            // 
            // placeNumberLabel
            // 
            this.placeNumberLabel.AutoSize = true;
            this.placeNumberLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNumberLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.placeNumberLabel.Location = new System.Drawing.Point(100, 105);
            this.placeNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Size = new System.Drawing.Size(144, 30);
            this.placeNumberLabel.TabIndex = 14;
            this.placeNumberLabel.Text = "Place Number";
            // 
            // placeNameValue
            // 
            this.placeNameValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNameValue.Location = new System.Drawing.Point(275, 155);
            this.placeNameValue.Margin = new System.Windows.Forms.Padding(4);
            this.placeNameValue.Name = "placeNameValue";
            this.placeNameValue.Size = new System.Drawing.Size(217, 35);
            this.placeNameValue.TabIndex = 17;
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.placeNameLabel.Location = new System.Drawing.Point(100, 160);
            this.placeNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(124, 30);
            this.placeNameLabel.TabIndex = 16;
            this.placeNameLabel.Text = "Place Name";
            // 
            // priceAmountValue
            // 
            this.priceAmountValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceAmountValue.Location = new System.Drawing.Point(275, 210);
            this.priceAmountValue.Margin = new System.Windows.Forms.Padding(4);
            this.priceAmountValue.Name = "priceAmountValue";
            this.priceAmountValue.Size = new System.Drawing.Size(217, 35);
            this.priceAmountValue.TabIndex = 19;
            // 
            // priceAmountLabel
            // 
            this.priceAmountLabel.AutoSize = true;
            this.priceAmountLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceAmountLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.priceAmountLabel.Location = new System.Drawing.Point(100, 215);
            this.priceAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceAmountLabel.Name = "priceAmountLabel";
            this.priceAmountLabel.Size = new System.Drawing.Size(139, 30);
            this.priceAmountLabel.TabIndex = 18;
            this.priceAmountLabel.Text = "Price Amount";
            // 
            // PricePercentage
            // 
            this.PricePercentage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PricePercentage.Location = new System.Drawing.Point(275, 316);
            this.PricePercentage.Margin = new System.Windows.Forms.Padding(4);
            this.PricePercentage.Name = "PricePercentage";
            this.PricePercentage.Size = new System.Drawing.Size(217, 35);
            this.PricePercentage.TabIndex = 21;
            this.PricePercentage.Text = "0";
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.AutoSize = true;
            this.prizePercentageLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizePercentageLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.prizePercentageLabel.Location = new System.Drawing.Point(100, 316);
            this.prizePercentageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(167, 30);
            this.prizePercentageLabel.TabIndex = 20;
            this.prizePercentageLabel.Text = "Price Percentage";
            // 
            // orlabel
            // 
            this.orlabel.AutoSize = true;
            this.orlabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orlabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.orlabel.Location = new System.Drawing.Point(259, 265);
            this.orlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orlabel.Name = "orlabel";
            this.orlabel.Size = new System.Drawing.Size(48, 30);
            this.orlabel.TabIndex = 22;
            this.orlabel.Text = "-or-";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.BackColor = System.Drawing.Color.White;
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createPrizeButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.createPrizeButton.Location = new System.Drawing.Point(207, 371);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(206, 64);
            this.createPrizeButton.TabIndex = 23;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = false;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(706, 458);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.orlabel);
            this.Controls.Add(this.PricePercentage);
            this.Controls.Add(this.prizePercentageLabel);
            this.Controls.Add(this.priceAmountValue);
            this.Controls.Add(this.priceAmountLabel);
            this.Controls.Add(this.placeNameValue);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.placeNumberValue);
            this.Controls.Add(this.placeNumberLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox placeNumberValue;
        private System.Windows.Forms.Label placeNumberLabel;
        private System.Windows.Forms.TextBox placeNameValue;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.TextBox priceAmountValue;
        private System.Windows.Forms.Label priceAmountLabel;
        private System.Windows.Forms.TextBox PricePercentage;
        private System.Windows.Forms.Label prizePercentageLabel;
        private System.Windows.Forms.Label orlabel;
        private System.Windows.Forms.Button createPrizeButton;
    }
}