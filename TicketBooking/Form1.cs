using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketBooking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //event handlers
            _comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            _comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            _quit.Click += Quit_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _comboBox1.Items.Add("Adult");
            _comboBox1.Items.Add("Child");

            /*comboBox4.Items.Add("0-3");
            comboBox4.Items.Add("4-12");
            comboBox4.Items.Add("13-50");
            comboBox4.Items.Add("51-80");
            comboBox5.Items.Add("1350");
            comboBox5.Items.Add("1000");
            comboBox5.Items.Add("0");
            comboBox5.Items.Add("600");*/
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _comboBox2.Items.Clear();

            if ((string)_comboBox1.SelectedItem == "Adult")
            {
                _comboBox2.Items.Add("13-50");
                _comboBox2.Items.Add("51-80");
            }
            else if ((string)_comboBox1.SelectedItem == "Child")
            {
                _comboBox2.Items.Add("0-3");
                _comboBox2.Items.Add("4-12");
            }

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)_comboBox2.SelectedItem == "13-50")
            {
                _priceLabel.Text = "Price: 1350";
            }
            else if ((string)_comboBox2.SelectedItem == "51-80")
            {
                _priceLabel.Text = "Price: 1000";
            }
            else if ((string)_comboBox2.SelectedItem == "0-3")
            {
                _priceLabel.Text = "Price: FREE";
            }
            else if ((string)_comboBox2.SelectedItem == "4-12")
            {
                _priceLabel.Text = "Price: 600";
            }
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Form2 close = new Form2();
            close.ShowDialog();
        }
    }
}
