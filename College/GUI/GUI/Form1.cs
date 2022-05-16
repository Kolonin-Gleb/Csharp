using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;


namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Настройка полей таблицы
            columnID.DataType = Type.GetType("System.Int32");
            columnID.AutoIncrement = true;
            columnID.Unique = true;
            columnID.AllowDBNull = false;
            // Настройка ФИО
            columnName.AllowDBNull = false;
            //columnName.



            tableEmployee.Columns.Add(columnID);
            dataset.Tables.Add(tableEmployee);
        }

        // Поля для таблицы
        DataSet dataset = new DataSet();
        DataTable tableEmployee = new DataTable("Emp");
        DataColumn columnID = new DataColumn();
        DataColumn columnName = new DataColumn();
        DataColumn columnLastname = new DataColumn();
        DataColumn columnSurname = new DataColumn();
        DataColumn columnPosition = new DataColumn();
        DataColumn columnPhone = new DataColumn();





        private void EmployeeFill()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
