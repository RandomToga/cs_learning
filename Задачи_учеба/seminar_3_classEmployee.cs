/*Разработать на C# класс "Сотрудник" (Employee) с закрытыми информационными членами.
Действия над объектами класса (методы класса)
•	получение информации о месте работы, занимаемой должности, стаже работы, заработной плате
•	изменение должности
•	начисление заработной платы
•	вывод личных данных
•	операции сравнения объектов ==, !=, <, > (перегрузка операций)
Статический метод
•	Получение количества сотрудников*/


using System;

public class Employee
{

    private string organization;
    private string position;
    private double experience;
    private string name;
    private char gender;
    private int age;
    private double salary;


    private static int count = 0;

    //конструктор класса
    public Employee(string organization, string position, double experience, string name, char gender, int age)
    {
        this.organization = organization;
        this.position = position;
        this.experience = experience;
        this.name = name;
        this.gender = gender;
        this.age = age;
        this.salary = 0;
        count++;
    }
    public void Dispose()
    { //аналог деструктора в C++
        GC.SuppressFinalize(this);
        count--;
    }

    public void Information()
    {
        Console.WriteLine("Организация: " + organization);
        Console.WriteLine("Должность: " + position);
        Console.WriteLine("Стаж работы: " + experience);
        Console.WriteLine("ФИО: " + name);
        Console.WriteLine("Пол: " + gender);
        Console.WriteLine("Зарплата: " + salary);
    }
    public void SetPosition(string position)
    {
        this.position = position;
    }

    public void SalPlus(double sum)
    {
        salary += sum;
    }

    public void Information2()
    {
        Console.WriteLine("ФИО: " + name);
        Console.WriteLine("Возраст: " + age);
        Console.WriteLine("Пол: " + gender);
    }
    public static int GetCount()
    {
        return count;
    }

    //перегрузка оператора ==
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        return employee1.name == employee2.name &&
               employee1.age == employee2.age &&
               employee1.gender == employee2.gender;
    }

    //перегрузка оператора !=
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        return !(employee1 == employee2);
    }

    //перегрузка оператора < по опыту
    public static bool operator <(Employee employee1, Employee employee2)
    {
        return employee1.experience < employee2.experience;
    }

    //перегрузка оператора > по опыту
    public static bool operator >(Employee employee1, Employee employee2)
    {
        return employee1.experience > employee2.experience;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Employee[] employees = new Employee[2] { new Employee("Организация1", "Разработчик", 3.5, "Дима", 'M', 30), new Employee("Организация2", "Тестировщик", 4.5, "Маша", 'F', 30) };
        Console.WriteLine("Количество чуваков на работе " + Employee.GetCount());
        employees[1].Dispose();
        Console.WriteLine("Количество чуваков на работе " + Employee.GetCount());
        employees[1].SalPlus(30000);
        for (int i = 0; i < 2; i++)
        {
            employees[i].Information();
        }
        if (employees[0] > employees[1])
        {
            Console.WriteLine("Первый круче");
        }
        else
        {
            Console.WriteLine("Второй круче");
        }
    }
}