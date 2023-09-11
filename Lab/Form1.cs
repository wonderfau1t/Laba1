using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderClass;

namespace Lab
{
    public partial class Form1 : Form
    {
        private BindingList<Order> orders;
        public Form1()
        {
            InitializeComponent();
            orders = new BindingList<Order>();
            dataGridView1.DataSource = orders;
        }

        

        private void addOrder_Click(object sender, EventArgs e)
        {
            try
            {
                string deviceType = deviceTypeBox.SelectedItem.ToString();
                string deviceBrand = deviceBrandBox.SelectedItem.ToString();
                string priority = priorityBox.SelectedItem.ToString();
                DateTime date = orderDate.Value;
                Order order = new Order(deviceType, deviceBrand, date, priority);
                calculatedSumBox.Text = $"{order.Sum:C2}";
                orders.Add(order);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void changeStatusButton_Click(object sender, EventArgs e)
        {
            try
            {
                string status = statusSelectBox.SelectedItem.ToString();
                int rowId = dataGridView1.SelectedCells[0].RowIndex;
                orders[rowId].Status = (status == "Выполнен") ? true : false;
                dataGridView1.Refresh();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Выберите статус!");
                return;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Выберите строку!");
                return;
            }
        }
    }
}
 