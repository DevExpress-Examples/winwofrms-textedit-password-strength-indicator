using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextEditPasswordStrengthBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void textEditPwdStrength_Leave(object sender, EventArgs e)
        {
            TextEditPwdStrength te = sender as TextEditPwdStrength;
            te.Properties.PasswordChar = '*';
        }

        void textEditPwdStrength_Enter(object sender, EventArgs e)
        {
            TextEditPwdStrength te = sender as TextEditPwdStrength;
            te.Properties.PasswordChar = '\0';
        }
    }
}
