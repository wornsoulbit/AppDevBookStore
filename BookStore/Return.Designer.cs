
namespace BookStore
{
    partial class Return
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
            this.NextButton = new System.Windows.Forms.Button();
            this.SnTextbox = new System.Windows.Forms.TextBox();
            this.AuthorTextbox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CatalogButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(178, 137);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 40;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SnTextbox
            // 
            this.SnTextbox.Location = new System.Drawing.Point(111, 76);
            this.SnTextbox.Name = "SnTextbox";
            this.SnTextbox.Size = new System.Drawing.Size(140, 20);
            this.SnTextbox.TabIndex = 39;
            // 
            // AuthorTextbox
            // 
            this.AuthorTextbox.Location = new System.Drawing.Point(111, 46);
            this.AuthorTextbox.Name = "AuthorTextbox";
            this.AuthorTextbox.Size = new System.Drawing.Size(140, 20);
            this.AuthorTextbox.TabIndex = 38;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(111, 12);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(140, 20);
            this.NameTextbox.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Serial number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Name of the book:";
            // 
            // CatalogButton
            // 
            this.CatalogButton.Location = new System.Drawing.Point(97, 137);
            this.CatalogButton.Name = "CatalogButton";
            this.CatalogButton.Size = new System.Drawing.Size(75, 23);
            this.CatalogButton.TabIndex = 33;
            this.CatalogButton.Text = "Catalog";
            this.CatalogButton.UseVisualStyleBackColor = true;
            this.CatalogButton.Click += new System.EventHandler(this.CatalogButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(97, 184);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 32;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click_1);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(16, 137);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 31;
            this.SubmitButton.Text = "Return";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 229);
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
            this.Name = "Return";
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox SnTextbox;
        private System.Windows.Forms.TextBox AuthorTextbox;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CatalogButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SubmitButton;
    }
}