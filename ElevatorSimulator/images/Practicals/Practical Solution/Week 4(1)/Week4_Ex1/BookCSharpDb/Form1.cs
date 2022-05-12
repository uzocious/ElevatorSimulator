using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookCSharpDb
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }        

        private void txtPages_TextChanged(object sender, EventArgs e)
        {
            btnInsert.Enabled = true;
        }


        void Display_Records(object s, EventArgs e)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(dbconnection);
                OleDbCommand comm = new OleDbCommand(dbcommand, conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(comm);

                conn.Open();

                while (filled == false)
                {
                    adapter.Fill(ds);
                    filled = true;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                string message = "Error in connection to datasource" + ex.ToString();
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
            lstDisplayBooks.Items.Clear();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lstDisplayBooks.Items.Add(row["BookKey"] + " " + row["Title"] + " (" + row["Pages"] + ")");
            }
            txtBookKey.Enabled = true;
            txtTitle.Enabled = true;
            txtPages.Enabled = true;
        }

        void Edit_Title(object s, EventArgs e)
        {


        }

        void Exit(object s, EventArgs e)
        {
            Application.Exit();
        }

        void Select_ListBox_Record(object s, EventArgs e)
        {
            targetRow = ds.Tables[0].Rows[lstDisplayBooks.SelectedIndex];

        }

        void TextBox_Update(object s, EventArgs e)
        {
            btnEditTitle.Enabled = true;
        }

        void Clear_List_Box(object s, EventArgs e)
        {
            lstDisplayBooks.Items.Clear();
        }

        void Delete_Record(object s, EventArgs e)
        {

        }

        void Insert_Record(object s, EventArgs e)
        {

        }

        void Add_Publisher_Table(object s, EventArgs e)
        {

        }
        void Select_List_Item(object s, EventArgs e)
        {
            txtEditTitle.Enabled = true;
            btnDelete.Enabled = true;
        }
    }
}
