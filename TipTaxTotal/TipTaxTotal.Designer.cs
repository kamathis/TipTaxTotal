namespace TipTaxTotal
{
    partial class TipTaxTotal
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
            this.mealLabel = new System.Windows.Forms.Label();
            this.mealTextBox = new System.Windows.Forms.TextBox();
            this.tipLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.displayTipLabel = new System.Windows.Forms.Label();
            this.displayTaxLabel = new System.Windows.Forms.Label();
            this.displayTotalLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mealLabel
            // 
            this.mealLabel.AutoSize = true;
            this.mealLabel.Location = new System.Drawing.Point(15, 28);
            this.mealLabel.Name = "mealLabel";
            this.mealLabel.Size = new System.Drawing.Size(114, 13);
            this.mealLabel.TabIndex = 0;
            this.mealLabel.Text = "Enter the meal charge:";
            // 
            // mealTextBox
            // 
            this.mealTextBox.Location = new System.Drawing.Point(157, 30);
            this.mealTextBox.Name = "mealTextBox";
            this.mealTextBox.Size = new System.Drawing.Size(117, 20);
            this.mealTextBox.TabIndex = 1;
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.Location = new System.Drawing.Point(18, 69);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(51, 13);
            this.tipLabel.TabIndex = 2;
            this.tipLabel.Text = "15% Tip: ";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(20, 106);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(77, 13);
            this.taxLabel.TabIndex = 3;
            this.taxLabel.Text = "7% Sales Tax: ";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(18, 138);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(69, 13);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "Grand Total: ";
            // 
            // displayTipLabel
            // 
            this.displayTipLabel.AutoSize = true;
            this.displayTipLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayTipLabel.Location = new System.Drawing.Point(157, 72);
            this.displayTipLabel.Name = "displayTipLabel";
            this.displayTipLabel.Size = new System.Drawing.Size(2, 15);
            this.displayTipLabel.TabIndex = 5;
            // 
            // displayTaxLabel
            // 
            this.displayTaxLabel.AutoSize = true;
            this.displayTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayTaxLabel.Location = new System.Drawing.Point(156, 103);
            this.displayTaxLabel.Name = "displayTaxLabel";
            this.displayTaxLabel.Size = new System.Drawing.Size(2, 15);
            this.displayTaxLabel.TabIndex = 6;
            // 
            // displayTotalLabel
            // 
            this.displayTotalLabel.AutoSize = true;
            this.displayTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayTotalLabel.Location = new System.Drawing.Point(154, 138);
            this.displayTotalLabel.Name = "displayTotalLabel";
            this.displayTotalLabel.Size = new System.Drawing.Size(2, 15);
            this.displayTotalLabel.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(25, 211);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(129, 38);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate Tip, Tax and Total";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(175, 211);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 38);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // TipTaxTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.displayTotalLabel);
            this.Controls.Add(this.displayTaxLabel);
            this.Controls.Add(this.displayTipLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.mealTextBox);
            this.Controls.Add(this.mealLabel);
            this.Name = "TipTaxTotal";
            this.Text = "Tip, Tax and Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mealLabel;
        private System.Windows.Forms.TextBox mealTextBox;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label displayTipLabel;
        private System.Windows.Forms.Label displayTaxLabel;
        private System.Windows.Forms.Label displayTotalLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

