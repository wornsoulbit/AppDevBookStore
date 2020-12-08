
namespace BookStore
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.AuthorTextbox = new System.Windows.Forms.TextBox();
            this.SnTextbox = new System.Windows.Forms.TextBox();
            this.PriceTextbox = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.BuyButton = new System.Windows.Forms.Button();
            this.StoreChooseButton = new System.Windows.Forms.Button();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionsToolStripMenuItem,
            this.styleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(349, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellToolStripMenuItem,
            this.borrowToolStripMenuItem,
            this.returnToolStripMenuItem,
            this.memberToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.functionsToolStripMenuItem.Text = "Functions";
            // 
            // sellToolStripMenuItem
            // 
            this.sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            this.sellToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sellToolStripMenuItem.Text = "Sell";
            this.sellToolStripMenuItem.Click += new System.EventHandler(this.sellToolStripMenuItem_Click);
            // 
            // borrowToolStripMenuItem
            // 
            this.borrowToolStripMenuItem.Name = "borrowToolStripMenuItem";
            this.borrowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borrowToolStripMenuItem.Text = "Borrow";
            this.borrowToolStripMenuItem.Click += new System.EventHandler(this.borrowToolStripMenuItem_Click);
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.styleToolStripMenuItem.Text = "Style";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name of the book:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Serial number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Author:";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(113, 48);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(140, 20);
            this.NameTextbox.TabIndex = 6;
            // 
            // AuthorTextbox
            // 
            this.AuthorTextbox.Location = new System.Drawing.Point(113, 82);
            this.AuthorTextbox.Name = "AuthorTextbox";
            this.AuthorTextbox.Size = new System.Drawing.Size(140, 20);
            this.AuthorTextbox.TabIndex = 7;
            // 
            // SnTextbox
            // 
            this.SnTextbox.Location = new System.Drawing.Point(113, 112);
            this.SnTextbox.Name = "SnTextbox";
            this.SnTextbox.Size = new System.Drawing.Size(140, 20);
            this.SnTextbox.TabIndex = 8;
            // 
            // PriceTextbox
            // 
            this.PriceTextbox.Location = new System.Drawing.Point(113, 142);
            this.PriceTextbox.Name = "PriceTextbox";
            this.PriceTextbox.Size = new System.Drawing.Size(140, 20);
            this.PriceTextbox.TabIndex = 9;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(177, 179);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 11;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(15, 179);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(75, 23);
            this.BuyButton.TabIndex = 13;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // StoreChooseButton
            // 
            this.StoreChooseButton.Location = new System.Drawing.Point(96, 179);
            this.StoreChooseButton.Name = "StoreChooseButton";
            this.StoreChooseButton.Size = new System.Drawing.Size(75, 23);
            this.StoreChooseButton.TabIndex = 14;
            this.StoreChooseButton.Text = "Store selection";
            this.StoreChooseButton.UseVisualStyleBackColor = true;
            this.StoreChooseButton.Click += new System.EventHandler(this.StoreChooseButton_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.memberToolStripMenuItem.Text = "Member";
            this.memberToolStripMenuItem.Click += new System.EventHandler(this.memberToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookStore.Properties.Resources.ds;
            this.ClientSize = new System.Drawing.Size(349, 215);
            this.Controls.Add(this.StoreChooseButton);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PriceTextbox);
            this.Controls.Add(this.SnTextbox);
            this.Controls.Add(this.AuthorTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Welcome to the .NET Book Store!";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox AuthorTextbox;
        private System.Windows.Forms.TextBox SnTextbox;
        private System.Windows.Forms.TextBox PriceTextbox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Button StoreChooseButton;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
    }
}

