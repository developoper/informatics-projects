using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IM_Lab_work_2
{
    public partial class authorizationForm : Form
    {
        public authorizationForm()
        {
            InitializeComponent();
        }




        // Кнопка выхода
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.DimGray;
        }





        // Возможность перетаскивания окна
        Point point;
       
        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }





        // Проверка CheckBox`а
        private void showCheck_Click(object sender, EventArgs e)
        {
            if (showCheck.Checked == true)
            {
                passText.UseSystemPasswordChar = true;
            }
            else
            {
                passText.UseSystemPasswordChar = false;
            }
        }





        // Проверка login`а и password`а
        private void authorizationButton_Click(object sender, EventArgs e)
        {
            string log = logText.Text;
            string pass = passText.Text;

            if (log == "takhtaulov" && pass == "12312345")
            {
                organiserForm newForm = new organiserForm();
                newForm.Show();

                //this.Hide();
            }
            else
            {
                MessageBox.Show("FAIL! Wrong login or password!");
            }
        }


        


        // Подсказки
        private void logText_MouseEnter(object sender, EventArgs e)
        {
            logTip.Show("Login must contain latin letters or/and digits", logText);
        }

        private void passText_MouseEnter(object sender, EventArgs e)
        {
            passTip.Show("Password must contain latin letters or/and digits", passText);
        }
    }
}
