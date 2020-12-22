using System.ComponentModel;

namespace TrackerUI
{
    partial class CreatePrizeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            this.createPrizeLabel = new System.Windows.Forms.Label();
            this.placeNumberValue = new System.Windows.Forms.TextBox();
            this.placeNumberLabel = new System.Windows.Forms.Label();
            this.prizeAmountValue = new System.Windows.Forms.TextBox();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.placeNameValue = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.prizePercentageValue = new System.Windows.Forms.TextBox();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createPrizeLabel
            // 
            this.createPrizeLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.createPrizeLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.createPrizeLabel.Location = new System.Drawing.Point(14, 3);
            this.createPrizeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.createPrizeLabel.Name = "createPrizeLabel";
            this.createPrizeLabel.Size = new System.Drawing.Size(293, 52);
            this.createPrizeLabel.TabIndex = 13;
            this.createPrizeLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            this.placeNumberValue.Location = new System.Drawing.Point(231, 58);
            this.placeNumberValue.Name = "placeNumberValue";
            this.placeNumberValue.Size = new System.Drawing.Size(151, 43);
            this.placeNumberValue.TabIndex = 15;
            // 
            // placeNumberLabel
            // 
            this.placeNumberLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.placeNumberLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.placeNumberLabel.Location = new System.Drawing.Point(14, 61);
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Size = new System.Drawing.Size(180, 34);
            this.placeNumberLabel.TabIndex = 14;
            this.placeNumberLabel.Text = "Place Number";
            // 
            // prizeAmountValue
            // 
            this.prizeAmountValue.Location = new System.Drawing.Point(231, 156);
            this.prizeAmountValue.Name = "prizeAmountValue";
            this.prizeAmountValue.Size = new System.Drawing.Size(151, 43);
            this.prizeAmountValue.TabIndex = 17;
            this.prizeAmountValue.Text = "0";
            // 
            // prizeAmountLabel
            // 
            this.prizeAmountLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.prizeAmountLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.prizeAmountLabel.Location = new System.Drawing.Point(14, 159);
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            this.prizeAmountLabel.Size = new System.Drawing.Size(180, 34);
            this.prizeAmountLabel.TabIndex = 16;
            this.prizeAmountLabel.Text = "Prize Amount";
            // 
            // placeNameValue
            // 
            this.placeNameValue.Location = new System.Drawing.Point(231, 107);
            this.placeNameValue.Name = "placeNameValue";
            this.placeNameValue.Size = new System.Drawing.Size(151, 43);
            this.placeNameValue.TabIndex = 16;
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.placeNameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.placeNameLabel.Location = new System.Drawing.Point(14, 110);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(180, 34);
            this.placeNameLabel.TabIndex = 18;
            this.placeNameLabel.Text = "Place Name";
            // 
            // prizePercentageValue
            // 
            this.prizePercentageValue.Location = new System.Drawing.Point(231, 291);
            this.prizePercentageValue.Name = "prizePercentageValue";
            this.prizePercentageValue.Size = new System.Drawing.Size(151, 43);
            this.prizePercentageValue.TabIndex = 21;
            this.prizePercentageValue.Text = "0";
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.prizePercentageLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.prizePercentageLabel.Location = new System.Drawing.Point(14, 294);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(213, 40);
            this.prizePercentageLabel.TabIndex = 20;
            this.prizePercentageLabel.Text = "Prize Percentage";
            // 
            // orLabel
            // 
            this.orLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.orLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.orLabel.Location = new System.Drawing.Point(163, 233);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(90, 40);
            this.orLabel.TabIndex = 22;
            this.orLabel.Text = "- Or -";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.BorderSize = 2;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.createPrizeButton.Location = new System.Drawing.Point(14, 359);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(368, 55);
            this.createPrizeButton.TabIndex = 28;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 431);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.prizePercentageValue);
            this.Controls.Add(this.prizePercentageLabel);
            this.Controls.Add(this.placeNameValue);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.prizeAmountValue);
            this.Controls.Add(this.prizeAmountLabel);
            this.Controls.Add(this.placeNumberValue);
            this.Controls.Add(this.placeNumberLabel);
            this.Controls.Add(this.createPrizeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button createPrizeButton;

        private System.Windows.Forms.Label orLabel;

        private System.Windows.Forms.Label prizeAmountLabel;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.Label prizePercentageLabel;
        private System.Windows.Forms.TextBox prizeAmountValue;
        private System.Windows.Forms.TextBox placeNameValue;
        private System.Windows.Forms.TextBox prizePercentageValue;

        private System.Windows.Forms.Label placeNumberLabel;
        private System.Windows.Forms.TextBox placeNumberValue;

        private System.Windows.Forms.Label createPrizeLabel;

        #endregion
    }
}