using System.Data;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BookCSharpDb
{
    partial class Form1
    {
        //private System.ComponentModel.IContainer components = null;
        private DataRow targetRow;
        private bool filled = false;
        public DataSet ds = new DataSet();
        string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source =../../BookCSharp.accdb";     //Binary is under ....\BookCSharpDb\bin\Debug   , DB is under ....\BookCSharpDb
        string dbcommand = "Select BookKey, Title, Pages from Books;";

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
        /// 
        private void InitializeComponent()
        {
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnEditTitle = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstDisplayBooks = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditTitle = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBookKey = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.btnAddPublisherTable = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDisplay.ForeColor = System.Drawing.Color.Black;
            this.btnDisplay.Location = new System.Drawing.Point(37, 276);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.Display_Records);
            // 
            // btnEditTitle
            // 
            this.btnEditTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEditTitle.Enabled = false;
            this.btnEditTitle.ForeColor = System.Drawing.Color.Black;
            this.btnEditTitle.Location = new System.Drawing.Point(37, 412);
            this.btnEditTitle.Name = "btnEditTitle";
            this.btnEditTitle.Size = new System.Drawing.Size(75, 23);
            this.btnEditTitle.TabIndex = 1;
            this.btnEditTitle.Text = "Edit Title";
            this.btnEditTitle.UseVisualStyleBackColor = false;
            this.btnEditTitle.Click += new System.EventHandler(this.Edit_Title);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(367, 462);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.Exit);
            // 
            // lstDisplayBooks
            // 
            this.lstDisplayBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstDisplayBooks.FormattingEnabled = true;
            this.lstDisplayBooks.Location = new System.Drawing.Point(35, 56);
            this.lstDisplayBooks.Name = "lstDisplayBooks";
            this.lstDisplayBooks.Size = new System.Drawing.Size(238, 147);
            this.lstDisplayBooks.TabIndex = 4;
            this.lstDisplayBooks.Click += new System.EventHandler(this.Select_ListBox_Record);
            this.lstDisplayBooks.SelectedIndexChanged += new System.EventHandler(this.Select_List_Item);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Book Records";

            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Updating.....";
            // 
            // txtEditTitle
            // 
            this.txtEditTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEditTitle.Enabled = false;
            this.txtEditTitle.Location = new System.Drawing.Point(37, 385);
            this.txtEditTitle.Name = "txtEditTitle";
            this.txtEditTitle.Size = new System.Drawing.Size(186, 20);
            this.txtEditTitle.TabIndex = 7;
            this.txtEditTitle.Click += new System.EventHandler(this.TextBox_Update);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(130, 276);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.Clear_List_Box);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnInsert.Enabled = false;
            this.btnInsert.ForeColor = System.Drawing.Color.Black;
            this.btnInsert.Location = new System.Drawing.Point(385, 204);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.Insert_Record);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(42, 505);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.Delete_Record);
            // 
            // txtBookKey
            // 
            this.txtBookKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBookKey.Enabled = false;
            this.txtBookKey.Location = new System.Drawing.Point(385, 90);
            this.txtBookKey.Name = "txtBookKey";
            this.txtBookKey.Size = new System.Drawing.Size(100, 20);
            this.txtBookKey.TabIndex = 13;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(385, 126);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 14;
            // 
            // txtPages
            // 
            this.txtPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPages.Enabled = false;
            this.txtPages.Location = new System.Drawing.Point(385, 163);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(100, 20);
            this.txtPages.TabIndex = 15;
            this.txtPages.TextChanged += new System.EventHandler(this.txtPages_TextChanged);
            // 
            // btnAddPublisherTable
            // 
            this.btnAddPublisherTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddPublisherTable.ForeColor = System.Drawing.Color.Black;
            this.btnAddPublisherTable.Location = new System.Drawing.Point(343, 382);
            this.btnAddPublisherTable.Name = "btnAddPublisherTable";
            this.btnAddPublisherTable.Size = new System.Drawing.Size(142, 23);
            this.btnAddPublisherTable.TabIndex = 16;
            this.btnAddPublisherTable.Text = "Add Publisher Table";
            this.btnAddPublisherTable.UseVisualStyleBackColor = false;
            this.btnAddPublisherTable.Click += new System.EventHandler(this.Add_Publisher_Table);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 68);
            this.label3.TabIndex = 17;
            this.label3.Text = "To insert a new record, click on Display. Enter the details below and click on In" +
    "sert.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "BookKey:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Title:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(288, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Pages:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(309, 51);
            this.label7.TabIndex = 21;
            this.label7.Text = "To show the list of books, click on Display. To clear the list click on Clear.";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(309, 68);
            this.label8.TabIndex = 22;
            this.label8.Text = "To edit a title, click on Display, and select a record.  Enter the new title belo" +
    "w and click on Edit Title.";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 453);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(309, 48);
            this.label9.TabIndex = 23;
            this.label9.Text = "To delete a book, click on Display and select a record.  Click on Delete. ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(551, 611);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddPublisherTable);
            this.Controls.Add(this.txtPages);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtBookKey);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtEditTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDisplayBooks);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEditTitle);
            this.Controls.Add(this.btnDisplay);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Display Records from Access Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDisplay;
        private Button btnEditTitle;
        private Button btnExit;
        private ListBox lstDisplayBooks;
        private Label label1;
        private Label label2;
        private TextBox txtEditTitle;
        private Button btnClear;
        private Button btnInsert;
        private Button btnAddPublisherTable;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;

        private Button btnDelete;
        private TextBox txtBookKey;
        private TextBox txtTitle;
        private TextBox txtPages;

    }
}

