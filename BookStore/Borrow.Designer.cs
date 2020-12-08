
namespace BookStore
{
    partial class Borrow
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CatalogButton = new System.Windows.Forms.Button();
            this.SnTextbox = new System.Windows.Forms.TextBox();
            this.AuthorTextbox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DaysNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DaysNum)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(95, 198);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 15;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click_1);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(14, 151);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 14;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CatalogButton
            // 
            this.CatalogButton.Location = new System.Drawing.Point(95, 151);
            this.CatalogButton.Name = "CatalogButton";
            this.CatalogButton.Size = new System.Drawing.Size(75, 23);
            this.CatalogButton.TabIndex = 20;
            this.CatalogButton.Text = "Catalog";
            this.CatalogButton.UseVisualStyleBackColor = true;
            this.CatalogButton.Click += new System.EventHandler(this.CatalogButton_Click);
            // 
            // SnTextbox
            // 
            this.SnTextbox.Location = new System.Drawing.Point(109, 90);
            this.SnTextbox.Name = "SnTextbox";
            this.SnTextbox.Size = new System.Drawing.Size(140, 20);
            this.SnTextbox.TabIndex = 27;
            // 
            // AuthorTextbox
            // 
            this.AuthorTextbox.Location = new System.Drawing.Point(109, 60);
            this.AuthorTextbox.Name = "AuthorTextbox";
            this.AuthorTextbox.Size = new System.Drawing.Size(140, 20);
            this.AuthorTextbox.TabIndex = 26;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(109, 26);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(140, 20);
            this.NameTextbox.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Serial number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name of the book:";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(176, 151);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 28;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Days:";
            // 
            // DaysNum
            // 
            this.DaysNum.Location = new System.Drawing.Point(110, 124);
            this.DaysNum.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.DaysNum.Name = "DaysNum";
            this.DaysNum.Size = new System.Drawing.Size(141, 20);
            this.DaysNum.TabIndex = 30;
            this.DaysNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 226);
            this.Controls.Add(this.DaysNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.SnTextbox);
            this.Controls.Add(this.AuthorTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CatalogButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SubmitButton);
            this.Name = "Borrow";
            this.Text = "Borrow";
            this.Load += new System.EventHandler(this.Borrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DaysNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CatalogButton;
        private System.Windows.Forms.TextBox SnTextbox;
        private System.Windows.Forms.TextBox AuthorTextbox;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown DaysNum;
    }
}