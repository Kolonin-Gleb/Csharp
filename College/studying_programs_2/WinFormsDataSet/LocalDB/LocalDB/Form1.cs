using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            //Настройка столбца ключевого элемента данных
            columnID.DataType = System.Type.GetType("System.Int32");
            columnID.AutoIncrement = true;
            columnID.Unique = true;
            columnID.AllowDBNull = false;
            columnID.ColumnName = "ID_Employee";
            //Настройка ФИО
            columnFirstName.AllowDBNull = false;
            columnFirstName.DataType = System.Type.GetType("System.String");
            columnFirstName.ColumnName = "FirstName";
            columnSecondName.AllowDBNull = false;
            columnSecondName.DataType = System.Type.GetType("System.String");
            columnSecondName.ColumnName = "SecondName";
            columnMiddleName.AllowDBNull = true;
            columnMiddleName.DataType = System.Type.GetType("System.String");
            columnMiddleName.DefaultValue = "-";
            columnMiddleName.ColumnName = "MiddleName";
            //Настройка должности
            columnPostName.DataType = System.Type.GetType("System.String");
            columnPostName.AllowDBNull = false;
            columnPostName.ColumnName = "PostName";
            //Настройка телефона
            columnPhone.DataType = System.Type.GetType("System.String");
            columnPhone.AllowDBNull = false;
            columnPhone.Unique = true;
            columnPhone.ColumnName = "PhoneNumber";
            //Присвоение виртуальной КЭШ-таблице, новых столбцов
            tableEmployee.Columns.Add(columnID);
            tableEmployee.Columns.Add(columnFirstName);
            tableEmployee.Columns.Add(columnSecondName);
            tableEmployee.Columns.Add(columnMiddleName);
            tableEmployee.Columns.Add(columnPostName);
            tableEmployee.Columns.Add(columnPhone);
            dataSet.Tables.Add(tableEmployee);
            dataSet.Tables[0].Rows.Add(new Object[] { null, "Иванов","Иван","Иванович", "Директор", "+7(976)677-22-77" });
            dataSet.Tables[0].Rows.Add(new Object[] { null, "Петров","Пётр","Петрович", "Бухгалтер", "+7(987)774-63-88" });
            dataSet.Tables[0].Rows.Add(new Object[] { null, "Андреев", "Анрдей", "Анрдеевич", "Консультант", "+7(925)733-63-88" });
            dataSet.Tables[0].Rows.Add(new Object[] { null,"Романов","Роман","Романович", "Консультант", "+7(934)563-01-56" });
        }
        DataSet dataSet = new DataSet();
        DataTable tableEmployee = new DataTable("Employee");
        DataColumn columnID = new DataColumn();
        DataColumn columnFirstName = new DataColumn();
        DataColumn columnSecondName = new DataColumn();
        DataColumn columnMiddleName= new DataColumn();
        DataColumn columnPostName = new DataColumn();
        DataColumn columnPhone = new DataColumn();


        private void EmployeeFill()
        {
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView1.Columns[0].HeaderText = "Код Сотрудника";
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Фамилия";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].HeaderText = "Должность";
            dataGridView1.Columns[5].HeaderText = "№ Телефона";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EmployeeFill();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.SelectedIndex = comboBox1.FindString(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataSet.Tables[0].Rows.Add(new Object[] { null, textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.SelectedItem, maskedTextBox1.Text });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataSet.Tables[0].Rows[Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)][1] = textBox1.Text;
            dataSet.Tables[0].Rows[Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)][2] = textBox2.Text;
            dataSet.Tables[0].Rows[Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)][3] = textBox3.Text;
            dataSet.Tables[0].Rows[Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)][4] = comboBox1.SelectedItem;
            dataSet.Tables[0].Rows[Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)][5] = maskedTextBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow rowDelete = dataSet.Tables[0].Rows[Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString())];
            dataSet.Tables[0].Rows.Remove(rowDelete);
        }
    }
}
