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
    public partial class Work : Form
    {
        Form backform;

        List<double[]> table_variants;
        int variant;

        public Work(Form backform)
        {
            InitializeComponent();
            this.backform = backform;
            menuStrip1.Renderer = new MyRenderer();
        }

        public List<double> get_variant(int number_variant)
        {
            if (!(0 <= number_variant && number_variant <= 23))
            {
                Random rn = new Random();
                variant = rn.Next(0, 24);
            }
            else
            {
                variant = number_variant;
            }
            
            List<double> variant_values = new List<double>();
            for (int i = 0; i < table_variants.Count; i++)
                variant_values.Add(table_variants[i][variant]);
                
            return variant_values;
        }

        void set_variant_to_labels(List<double> variant_values)
        {
            label11.Text = "" + variant_values[0];
            label12.Text = "" + variant_values[1];
            label13.Text = "" + variant_values[2];
            label14.Text = "" + variant_values[3];
            label15.Text = "" + variant_values[4];
            label16.Text = "" + variant_values[5];
            label17.Text = "" + variant_values[6];
            label18.Text = "" + variant_values[7];
            label19.Text = "" + variant_values[8];
        }

        private void Work_Load(object sender, EventArgs e)
        {
            table_variants = new List<double[]>();
            using (StreamReader reader = new StreamReader("Данные задач\\Варианты расчетных данных.csv"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(';');
                    double[] values = new double[fields.Length];
                    for (int i = 0; i < fields.Length; i++)
                        values[i] = Double.Parse(fields[i]);

                    table_variants.Add(values);
                }
            }

            List<double> variat_values = get_variant(-1);
            set_variant_to_labels(variat_values);
            comboBox1.SelectedIndex = variant - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Work_FormClosing(object sender, FormClosingEventArgs e)
        {
            backform.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            variant = comboBox1.SelectedIndex+1;
            List<double> variant_values = get_variant(variant-1);
            set_variant_to_labels(variant_values);
        }

        private void методичкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Методичка.pdf");
        }

        private void таблицыДляРасчетовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables form = new Tables();
            form.Show();
        }

        private void cправкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.Show();
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
