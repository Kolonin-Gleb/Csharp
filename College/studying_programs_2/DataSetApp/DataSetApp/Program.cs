using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Пространство имён, которое позволяет работать с КЭШ данными, в виде набора строк, столбцов, таблиц и областью таблиц


// Эта программа просто демонстрирует работу с объектом класса DataSet.
// Позволяет отобразить данные в виде таблицы
namespace DataSetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet dataSet = new DataSet(); //Позволяет объединять по общему признаку КЭШ-таблицы DataTable
            DataTable tablePost = new DataTable("tbPost"); // Класс позволяет определить область памяти для КЭШ-Таблицы, в качестве перегрузки указывется название данной таблицы в коллекции DataSet
            dataSet.Tables.Add(tablePost);
            DataColumn columnID = new DataColumn("ID_Post",typeof(int)); //Инициализация нового КЭШ-столбца, с указанием псевдонима и типа данных
            columnID.Caption = "Код Записи";
            columnID.AutoIncrement = true;
            DataColumn columnPostName = new DataColumn("Post_Name", typeof(string));
            columnPostName.Caption = "Название должности";
            columnID.Unique = true;
            DataColumn columnPostPricve = new DataColumn("Post_Price", typeof(decimal));
            columnPostPricve.Caption = "Оклад в руб.";
            dataSet.Tables[0].Columns.Add(columnID);
            dataSet.Tables[0].Columns.Add(columnPostName);
            dataSet.Tables[0].Columns.Add(columnPostPricve);
            DataRow row1 = dataSet.Tables[0].NewRow();
            row1["Post_Name"] = "Директор";
            row1["Post_Price"] = 150000.50;
            DataRow row2 = dataSet.Tables[0].NewRow();
            row2["Post_Name"] = "Бухгалтер";
            row2["Post_Price"] = 125000.50;
            DataRow row3 = dataSet.Tables[0].NewRow();
            row3["Post_Name"] = "Продавец";
            row3["Post_Price"] = 110000.50;
            dataSet.Tables[0].Rows.Add(row1);
            dataSet.Tables[0].Rows.Add(row2);
            dataSet.Tables[0].Rows.Add(row3);
            for (int colN = 0; colN < dataSet.Tables[0].Columns.Count; colN++)
            {
                Console.Write(string.Format("{0} ({1}) \t |\t", dataSet.Tables[0].Columns[colN].Caption, dataSet.Tables[0].Columns[colN].ColumnName));
            }
            Console.WriteLine();
            for (int col = 0; col < dataSet.Tables[0].Columns.Count; col++)
            {
                for (int row = 0; row < dataSet.Tables[0].Rows.Count; row++)
                {
                    Console.Write("\t\t"+dataSet.Tables[0].Rows[col][row]+"\t\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            //Console.WriteLine(dataSet.Tables.Count); Вывод количества КЭШ таблиц из области таблиц
            //Console.WriteLine(dataSet.Tables[0].TableName); Вывод названия КЭШ таблицы по индексу
            //Console.WriteLine(dataSet.Tables["tbPost"].TableName); Вывод названия КЭШ таблицы по псевдониму
            //Console.WriteLine(dataSet.Tables[0].Rows.Count); Вывод количества строк в КЭШ табице
            //Console.WriteLine(dataSet.Tables[0].Columns.Count); Вывод количества столбцов в КЭШ таблице
            Console.WriteLine(string.Format("Столбцов: {0}, строк: {1}, Таблица: {2}", tablePost.Columns.Count, tablePost.Rows.Count, tablePost.TableName));
            Console.ReadKey();
        }
    }
}
