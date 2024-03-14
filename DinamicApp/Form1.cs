using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamicApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MouseClick += MainForm_MouseClick;
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Button newButton = new Button();
                newButton.Text = $"({e.X}, {e.Y})";
                newButton.Location = new System.Drawing.Point(e.X, e.Y);
                newButton.AutoSize = true;
                newButton.Click += (s, args) =>
                {
                    MessageBox.Show($"Нажата кнопка в позиции: {newButton.Location}");
                };
                this.Controls.Add(newButton);
            }
        }
    }
}
