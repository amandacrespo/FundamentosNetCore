using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form19SumarCheckbox : Form
    {
        int suma;
        List<CheckBox> chks;

        public Form19SumarCheckbox()
        {
            InitializeComponent();
            this.suma = 0;
            this.chks = new List<CheckBox>();

            foreach (CheckBox chk in this.panel1.Controls)
            {
                this.chks.Add((CheckBox)chk);
                chk.CheckedChanged += SumarNums;
            }
            this.txtRes.Text = this.suma.ToString();
        }

        private void Form19SumarCheckbox_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            foreach (CheckBox chk in this.chks)
            {
                chk.Text = random.Next(1, 50).ToString();
            }
        }

        void SumarNums(object sender, EventArgs e)
        {
            int newSum = 0;
            foreach (CheckBox chk in this.chks)
            {
                if (chk.Checked)
                {
                    newSum += int.Parse(chk.Text);
                }
            }
            this.suma = newSum;
            this.txtRes.Text = this.suma.ToString();
        }
    }
}
