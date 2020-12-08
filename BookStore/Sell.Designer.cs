
namespace BookStore
{
    partial class Sell
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
            this.SellButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BookNameTextbox = new System.Windows.Forms.TextBox();
            this.AuthorTextbox = new System.Windows.Forms.TextBox();
            this.SnTextbox = new System.Windows.Forms.TextBox();
            this.PriceUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PriceUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SellButton
            // 
            this.SellButton.Location = new System.Drawing.Point(107, 144);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(86, 23);
            this.SellButton.TabIndex = 0;
            this.SellButton.Text = "Sell";
            this.SellButton.UseVisualStyleBackColor = true;
            this.SellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(199, 144);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(89, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name of the book:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selling price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Serial Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Author:";
            // 
            // BookNameTextbox
            // 
            this.BookNameTextbox.Location = new System.Drawing.Point(107, 12);
            this.BookNameTextbox.Name = "BookNameTextbox";
            this.BookNameTextbox.Size = new System.Drawing.Size(181, 20);
            this.BookNameTextbox.TabIndex = 6;
            // 
            // AuthorTextbox
            // 
            this.AuthorTextbox.Location = new System.Drawing.Point(107, 38);
            this.AuthorTextbox.Name = "AuthorTextbox";
            this.AuthorTextbox.Size = new System.Drawing.Size(181, 20);
            this.AuthorTextbox.TabIndex = 7;
            // 
            // SnTextbox
            // 
            this.SnTextbox.Location = new System.Drawing.Point(107, 90);
            this.SnTextbox.Name = "SnTextbox";
            this.SnTextbox.Size = new System.Drawing.Size(181, 20);
            this.SnTextbox.TabIndex = 9;
            // 
            // PriceUpDown
            // 
            this.PriceUpDown.Location = new System.Drawing.Point(107, 65);
            this.PriceUpDown.Name = "PriceUpDown";
            this.PriceUpDown.Size = new System.Drawing.Size(181, 20);
            this.PriceUpDown.TabIndex = 10;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(9, 144);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(92, 23);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Add to counter";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 179);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PriceUpDown);
            this.Controls.Add(this.SnTextbox);
            this.Controls.Add(this.AuthorTextbox);
            this.Controls.Add(this.BookNameTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SellButton);
            this.Name = "Sell";
            this.Text = "Sell";
            ((System.ComponentModel.ISupportInitialize)(this.PriceUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SellButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BookNameTextbox;
        private System.Windows.Forms.TextBox AuthorTextbox;
        private System.Windows.Forms.TextBox SnTextbox;
        private System.Windows.Forms.NumericUpDown PriceUpDown;
        private System.Windows.Forms.Button AddButton;
    }
}