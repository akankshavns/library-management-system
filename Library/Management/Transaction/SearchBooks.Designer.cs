﻿namespace Library.TransactionManagement
{
    partial class SearchBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridpanel = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.issueFormDetails1 = new Library.TransactionManagement.ShowBookDetail();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gridpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 629);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.gridpanel);
            this.panel3.Location = new System.Drawing.Point(3, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1275, 568);
            this.panel3.TabIndex = 1;
            // 
            // gridpanel
            // 
            this.gridpanel.Controls.Add(this.dataGridView);
            this.gridpanel.Location = new System.Drawing.Point(118, 17);
            this.gridpanel.Name = "gridpanel";
            this.gridpanel.Size = new System.Drawing.Size(591, 531);
            this.gridpanel.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(25, 18);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(542, 504);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BackButton);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.searchBox);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1278, 55);
            this.panel2.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Image = global::Library.Properties.Resources.Left_Arrow;
            this.BackButton.Location = new System.Drawing.Point(-1, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(41, 16);
            this.BackButton.TabIndex = 5;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(383, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "View Book Status...";
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.LightGray;
            this.searchBox.Location = new System.Drawing.Point(120, 14);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(224, 26);
            this.searchBox.TabIndex = 1;
            this.searchBox.Text = "Search Book...";
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click_1);
            this.searchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Library.Properties.Resources.Search;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(98, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 26);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // issueFormDetails1
            // 
            this.issueFormDetails1.availableBookId = null;
            this.issueFormDetails1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.issueFormDetails1.Location = new System.Drawing.Point(0, 0);
            this.issueFormDetails1.Name = "issueFormDetails1";
            this.issueFormDetails1.Size = new System.Drawing.Size(1228, 607);
            this.issueFormDetails1.TabIndex = 3;
            // 
            // SearchBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.issueFormDetails1);
            this.Name = "SearchBooks";
            this.Size = new System.Drawing.Size(1278, 629);
            this.Load += new System.EventHandler(this.issueBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gridpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ShowBookDetail issueFormDetails1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel gridpanel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BackButton;
    }
}
