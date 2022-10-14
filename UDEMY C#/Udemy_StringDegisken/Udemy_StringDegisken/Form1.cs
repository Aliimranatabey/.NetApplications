using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udemy_StringDegisken
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string name, surname, age, job, gender;
			name = textBox1.Text;
			surname = textBox2.Text;
			job = textBox3.Text;
			age = maskedTextBox1.Text;
			gender = "";
			bool isChecked = radioButton1.Checked;
			if (isChecked)
				gender = radioButton1.Text;
			else
				gender = radioButton2.Text;
			listBox1.Items.Add(name);
			listBox1.Items.Add(surname);
			listBox1.Items.Add(job);
			listBox1.Items.Add(age);
			listBox1.Items.Add(gender);
			listBox1.Items.Add("----------------------------------");

		}
	}
}
