﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace asm1_db
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult check_Exit = MessageBox.Show("Do you want to exit?", "Confirm",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check_Exit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string pass = txtPass.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name", "Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please enter your pass", "Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (name == "vanh" && pass == "123")
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(" Invalid username or password", "Notice",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}