using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiation
{
    public partial class CheckWork : Form
    {
        Form backform;
        List<double[]> table_variant_answers;


        public CheckWork(Form backform)
        {
            InitializeComponent();
            this.backform = backform;
            menuStrip1.Renderer = new MyRenderer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckWork_FormClosing(object sender, FormClosingEventArgs e)
        {
            backform.Show();
        }

        private void методичкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Методичка.pdf");
        }

        private void cправкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.Show();
        }

        private void таблицыДляРасчетовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables form = new Tables();
            form.Show();
        }

        void Check_work()
        {
            int variant = comboBox1.SelectedIndex;

            if (variant == -1) MessageBox.Show("Вы не выбрали вариант", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                double[] answers = new double[5];
                answers[0] = Convert.ToDouble(numericUpDown1.Value);
                answers[1] = Convert.ToDouble(numericUpDown2.Value);
                answers[2] = Convert.ToDouble(numericUpDown3.Value);
                answers[3] = Convert.ToDouble(numericUpDown4.Value);
                answers[4] = (radioButton1.Checked) ? 1 : 0;  //A - 1, Б - 0, АБ - 2

                double error_rate = 0.2;

                bool[] result_answers = new bool[5];
                result_answers[0] = Math.Abs(answers[0] - table_variant_answers[variant][1]) <= error_rate;
                result_answers[1] = Math.Abs(answers[1] - table_variant_answers[variant][2]) <= error_rate;
                result_answers[2] = Math.Abs(answers[2] - table_variant_answers[variant][3]) <= error_rate;
                result_answers[3] = Math.Abs(answers[3] - table_variant_answers[variant][4]) <= error_rate;
                result_answers[4] = answers[4] == table_variant_answers[variant][5];

                if (variant == 12 || variant == 20) result_answers[4] = true;

                checkBox1.Checked = result_answers[0];
                checkBox2.Checked = result_answers[1];
                checkBox3.Checked = result_answers[2];
                checkBox4.Checked = result_answers[3];
                checkBox5.Checked = result_answers[4];

                if (!(result_answers[0] || result_answers[1] || result_answers[2] 
                    || result_answers[3] || result_answers[4])) 
                    MessageBox.Show("Работа проверена; Ни один из вариантов ответа неверен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Работа проверена; верные ответы были отмечены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        private void roundButton1_Click(object sender, EventArgs e)
        {
            Check_work();
        }

        private void CheckWork_Load(object sender, EventArgs e)
        {
            table_variant_answers = new List<double[]>();
            using (StreamReader reader = new StreamReader("Данные задач\\Ответы.csv"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(';');
                    double[] values = new double[fields.Length];
                    for (int i = 0; i < fields.Length; i++)
                        values[i] = Double.Parse(fields[i]);

                    table_variant_answers.Add(values);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Check_work();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
        }
    }
}
