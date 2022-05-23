// ВЫРЕЗАННЫЙ НЕНУЖНЫЙ КОД

//class Human
//{
//    public int Id = -1;
//    public string First_Name = "null", Second_Name = "null", Middle_Name = "null";
//    public int Age = -1;
//    public void humanGet()
//    {
//        Console.WriteLine(string.Format("№ человека: {0}, ФИО: {1} {2} {3}, Возраст: {4}.", Id, First_Name, Second_Name, Middle_Name, Age));
//    }
//    public void humanSet(int id, string first_name, string second_name, string middle_Name, int age)
//    {
//        Id = id;
//        First_Name = first_name;
//        Second_Name = second_name;
//        Middle_Name = middle_Name;
//        Age = age;
//    }
//}



//В данной конструкции говорится, что класс Employee наследует все свойтва и все события класса Human
//class Employee : Human
//{
//    string Post_Name = "Null";
//    decimal Post_Price = 0.0m;
//    public Employee()
//    {

//    }
//    public Employee(string post_name, decimal post_Price)
//    {
//        Post_Name = post_name;
//        Post_Price = post_Price;
//    }

//    public Employee(int id, string first_name, string second_name, string middle_Name, int age, string post_name, decimal post_Price)
//    {
//        humanSet(id, first_name, second_name, middle_Name, age);
//        employeeSet(post_name, post_Price);
//    }

//    public void employeeGet()
//    {
//        Console.WriteLine(string.Format("№ Сотрудника: {0}, Фамилия инициалы:{1} {2}.{3}., возрвст {4}, Занимаемая должность: {5}, с окладом {6} руб.", Id, First_Name,
//            Second_Name.Substring(0,1), Middle_Name.Substring(0,1), Age, Post_Name, Post_Price));
//    }

//    public void employeeSet(string post_name, decimal post_price)
//    {
//        Post_Name = post_name;
//        Post_Price = post_price;
//    }
//}

//Human human1 = new Human();
//human1.humanSet(1, "Иванов", "Иван", "Иванович", 46);
//Human human2 = new Human();
//human2.humanSet(2, "Петров", "Пётр", "Петрович", 27);
//Human human3 = new Human();
//human3.humanSet(3, "Антонов", "Антон", "Антонович", 67);
//human1.humanGet();
//human2.humanGet();
//human3.humanGet();
//Employee employee1 = new Employee();
//employee1.humanSet(1, "Иванов", "Иван", "Иванович", 46);
//employee1.employeeSet("Директор", 155000.59m);
//Employee employee2 = new Employee("Бухгалтер",125000.50m);
//employee2.humanSet(2, "Петров", "Пётр", "Петрович", 27);
//Employee employee3 = new Employee(3, "Антонов", "Антон", "Антонович", 67, "Консультант", 110000.59m);
//employee1.employeeGet();
//employee2.employeeGet();
//employee3.employeeGet();
//employee3.humanGet();
