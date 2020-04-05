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
    public partial class organiserForm : Form
    {
        public organiserForm()
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





        // Коллекция
        private void viewComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewComboBox.Items.Add("Memo");
            viewComboBox.Items.Add("Meeting");
            viewComboBox.Items.Add("Task");
        }





        // Заполнение mainDataGridView
        private void organiserForm_Load(object sender, EventArgs e)
        {
            mainDataGridView.RowCount = 12;

            for(int i = 0; i < mainDataGridView.RowCount; i++)
            {
                for(int j = 0; j < mainDataGridView.ColumnCount; j++)
                {
                    mainDataGridView.Rows[i].Cells[j].Value = i * mainDataGridView.ColumnCount + j + 1;
                }
            }
        }





        // Добавление
        private void addButton_Click(object sender, EventArgs e)
        {
            eventForm newForm = new eventForm();
            newForm.Show();

            //this.Hide();
        }
    }
}
