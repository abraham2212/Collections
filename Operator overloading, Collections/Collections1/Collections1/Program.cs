



using Collections1;
using Collections1.Models;
using System.Net.Cache;

Kelvin Kelvin = new Kelvin();
Celsius Celsius = new Celsius();
Console.WriteLine("Enter celcius degree:");
double c = double.Parse(Console.ReadLine());

double f = (c * 9 / 5) + 32;
double k = c + 273.15;

Console.WriteLine("From celcius to kelvin: " + k);
Console.WriteLine("From celcius to fahrenheit: " + f);




List<Author> authors= new List<Author>();

Author auto1 = new Author()
{
    Id= 1,
    Name="ali",
    Surname="aliyev",
    Age=23


};



Author auto2 = new Author()
{
    Id= 2,
    Name="aydin",
    Surname="qurbanov",
    Age=38




};

Author auto3 = new Author()
{
    Id= 3,
    Name="namiq",
    Surname="haciyev",
    Age=41




};

var result = auto3.Age< 40;
Console.WriteLine(result);


//for (int i = 0; i < authors.Count; i++)
//{
//    Console.WriteLine( authors[i]);
//}



//authors.Add(new Author());



List<Employee> employees = new List<Employee>()


        {
             new Employee {Id=101,   Name="ali", Salary=4000 ,},
             new Employee {Id=102,   Name="Ramiz"      , Salary=6000},
             new Employee {Id=103,   Name="Solmaz"    , Salary=7000},
             new Employee {Id=104,   Name="Ramzan"    , Salary=9000},
        };











