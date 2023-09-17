using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiation
{
    public partial class Tables : Form
    {
        public Tables()
        {
            InitializeComponent();
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) pictureBox1.Image = Image.FromFile(@"Таблицы\1.png");
            if (comboBox1.SelectedIndex == 1) pictureBox1.Image = Image.FromFile(@"Таблицы\2.png");
            if (comboBox1.SelectedIndex == 2) pictureBox1.Image = Image.FromFile(@"Таблицы\3.png");
            if (comboBox1.SelectedIndex == 3) pictureBox1.Image = Image.FromFile(@"Таблицы\4.png");
            if (comboBox1.SelectedIndex == 4) pictureBox1.Image = Image.FromFile(@"Таблицы\5.png");
            if (comboBox1.SelectedIndex == 5) pictureBox1.Image = Image.FromFile(@"Таблицы\6.png");
            if (comboBox1.SelectedIndex == 6) pictureBox1.Image = Image.FromFile(@"Таблицы\7.png");
            if (comboBox1.SelectedIndex == 7) pictureBox1.Image = Image.FromFile(@"Таблицы\8.png");
            if (comboBox1.SelectedIndex == 8) pictureBox1.Image = Image.FromFile(@"Таблицы\9.png");

        }
    }
}
