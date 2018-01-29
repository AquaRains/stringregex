using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace KakaotalcRemoveString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string pattern = @"\[.+\]\s\[.{2}.\d+:\d{2}\]\s";

            textBox2.Text = Regex.Replace(textBox1.Text, pattern, "", RegexOptions.Multiline);
        }
    }
}
