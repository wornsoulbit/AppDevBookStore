
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
            this.ContactTextbox = new System.Windows.Forms.TextBox();
            this.LastnameTextbox = new System.Windows.Forms.TextBox();
            this.FirstnameTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BookNameTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(164, 182);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 15;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(33, 182);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 14;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ContactTextbox
            // 
            this.ContactTextbox.Location = new System.Drawing.Point(122, 82);
            this.ContactTextbox.Name = "ContactTextbox";
            this.ContactTextbox.Size = new System.Drawing.Size(117, 20);
            this.ContactTextbox.TabIndex = 13;
            // 
            // LastnameTextbox
            // 
            this.LastnameTextbox.Location = new System.Drawing.Point(122, 50);
            this.LastnameTextbox.Name = "LastnameTextbox";
            this.LastnameTextbox.Size = new System.Drawing.Size(117, 20);
            this.LastnameTextbox.TabIndex = 12;
            // 
            // FirstnameTextbox
            // 
            this.FirstnameTextbox.Location = new System.Drawing.Point(122, 18);
            this.FirstnameTextbox.Name = "FirstnameTextbox";
            this.FirstnameTextbox.Size = new System.Drawing.Size(117, 20);
            this.FirstnameTextbox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contact number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Name of the book:";
            // 
            // BookNameTextbox
            // 
            this.BookNameTextbox.Location = new System.Drawing.Point(122, 108);
            this.BookNameTextbox.Name = "BookNameTextbox";
            this.BookNameTextbox.Size = new System.Drawing.Size(117, 20);
            this.BookNameTextbox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Card Number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 19;
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 245);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BookNameTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ContactTextbox);
            this.Controls.Add(this.LastnameTextbox);
            this.Controls.Add(this.FirstnameTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Borrow";
            this.Text = "Borrow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox ContactTextbox;
        private System.Windows.Forms.TextBox LastnameTextbox;
        private System.Windows.Forms.TextBox FirstnameTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BookNameTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}