﻿namespace Library.Board
{
    partial class TransactionBoard
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.IssueList = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.issue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewTransaction1 = new Library.TransactionManagement.ViewTransaction();
            this.returnBook1 = new Library.TransactionManagement.ReturnBook();
            this.issueFormDetails1 = new Library.TransactionManagement.ShowBookDetail();
            this.issueBook1 = new Library.TransactionManagement.SearchBooks();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.IssueList);
            this.panel3.Controls.Add(this.Return);
            this.panel3.Controls.Add(this.issue);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1231, 72);
            this.panel3.TabIndex = 7;
            // 
            // IssueList
            // 
            this.IssueList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IssueList.Location = new System.Drawing.Point(756, 6);
            this.IssueList.Name = "IssueList";
            this.IssueList.Size = new System.Drawing.Size(122, 59);
            this.IssueList.TabIndex = 2;
            this.IssueList.Text = "Record";
            this.IssueList.UseVisualStyleBackColor = true;
            this.IssueList.Click += new System.EventHandler(this.IssueList_Click_1);
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Return.Location = new System.Drawing.Point(572, 6);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(122, 59);
            this.Return.TabIndex = 2;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click_1);
            // 
            // issue
            // 
            this.issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.issue.Location = new System.Drawing.Point(397, 5);
            this.issue.Name = "issue";
            this.issue.Size = new System.Drawing.Size(122, 59);
            this.issue.TabIndex = 1;
            this.issue.Text = "Issue";
            this.issue.UseVisualStyleBackColor = true;
            this.issue.Click += new System.EventHandler(this.issue_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Book Management";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.viewTransaction1);
            this.panel2.Controls.Add(this.returnBook1);
            this.panel2.Controls.Add(this.issueFormDetails1);
            this.panel2.Controls.Add(this.issueBook1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1231, 593);
            this.panel2.TabIndex = 5;
            // 
            // viewTransaction1
            // 
            this.viewTransaction1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewTransaction1.Location = new System.Drawing.Point(0, -2);
            this.viewTransaction1.Name = "viewTransaction1";
            this.viewTransaction1.Size = new System.Drawing.Size(1231, 592);
            this.viewTransaction1.TabIndex = 4;
            this.viewTransaction1.Visible = false;
            // 
            // returnBook1
            // 
            this.returnBook1.Location = new System.Drawing.Point(0, -2);
            this.returnBook1.Name = "returnBook1";
            this.returnBook1.Size = new System.Drawing.Size(1225, 591);
            this.returnBook1.TabIndex = 3;
            this.returnBook1.Visible = false;
            // 
            // issueFormDetails1
            // 
            this.issueFormDetails1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.issueFormDetails1.Location = new System.Drawing.Point(0, -2);
            this.issueFormDetails1.Name = "issueFormDetails1";
            this.issueFormDetails1.Size = new System.Drawing.Size(1228, 591);
            this.issueFormDetails1.TabIndex = 2;
            this.issueFormDetails1.Visible = false;
            // 
            // issueBook1
            // 
            this.issueBook1.Location = new System.Drawing.Point(3, -1);
            this.issueBook1.Name = "issueBook1";
            this.issueBook1.Size = new System.Drawing.Size(1225, 591);
            this.issueBook1.TabIndex = 1;
            this.issueBook1.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Library.Properties.Resources.book;
            this.button1.Location = new System.Drawing.Point(387, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(395, 302);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TransactionBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "TransactionBoard";
            this.Size = new System.Drawing.Size(1231, 667);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button IssueList;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button issue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private TransactionManagement.SearchBooks issueBook1;
        private TransactionManagement.ViewTransaction viewTransaction1;
        private TransactionManagement.ReturnBook returnBook1;
        private TransactionManagement.ShowBookDetail issueFormDetails1;
    }
}
