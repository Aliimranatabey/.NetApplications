using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikAracEkleme
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Button btn = new Button();
			Point btnkonum = new Point(20, 10);
			btn.Location = btnkonum;
			btn.Name = "Button 2";
			btn.Text = "TIKLA";
			btn.BackColor = Color.Green;
			btn.Height = 50;
			btn.Width = 70;


			Label lbl = new Label();
			Point lblkonum = new Point(850,550);
			lbl.Name = "Label 1";
			lbl.Text = "MERHABA";
			lbl.BackColor = Color.Yellow;
			this.Controls.Add(lbl);
			lbl.AutoSize = true;
			
			


			
			for (int i = 0; i <=5; i++)
			{
				TextBox txt = new TextBox();
				Point txtkonum = new Point(300,i*20);
				txt.Location = txtkonum;
				txt.Name = "Textbox" + i;
				txt.Text = i.ToString();
				this.Controls.Add(txt);
			}
			this.Controls.Add(btn);
		}
	}
}
