





using Collections.Models;
using System.Collections;

//Employee employee1 = new Employee();

//employee1.Name = "pervin";
//employee1.Age = 25;
//employee1.Id = 1;



//Employee employee2 = new Employee();

//employee2.Name = "cavid";
//employee2.Age = 22;
//employee2.Id = 2;

//var result = employee1 > employee2;
//Console.WriteLine(result);


//Hashtable datas = new Hashtable();


//datas.Add(4, "cavid");

//datas.Add(2, "pervin");

//datas.Add(3, "mirze");

//foreach (DictionaryEntry item in datas)
//{
//    if ((int)item.Key==1)

//        Console.WriteLine(item.Value);

/*Console.WriteLine(item.Key+"-"+item.Value)*/
//}



//ArrayList datas = new ArrayList();

//datas.Add("salam");
//datas.Add(1);
//datas.Add(true);


//foreach (var item in datas)
//{
//    Console.WriteLine(item);




//}


//SortedList datas = new SortedList();
//datas.Add(1, "cavid");
//datas.Add(6, "pervin");
//datas.Add(4, "mirze");

//foreach (DictionaryEntry item in datas)
//{
//    Console.WriteLine(item.Key+"-"+item.Value);
//}



//List<int> datas = new List<int>();
//datas.Add(45);
//datas.Add(20);
//datas.Add(30);
////datas.Remove(20);
////datas.Reverse();
////Console.WriteLine(datas[0]);
//datas.RemoveAll(m=>m>20);
////datas.Sort();
//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}


//List<string> names = new List<string>() { "cavid", "cavid", "mirze", "aqsin", "elcan" };

//Console.WriteLine(names.Count);
//foreach (var item in names)
//{
//    Console.WriteLine(item);
//}

//for (int i = 0; i <names.Count ; i++)
//{
//    Console.WriteLine(names[i]) ;
//}
//foreach (var item in names)
//{
//	if (item =="cavid")
//	{
//		Console.WriteLine(item);
//	}
//}


//var result = names.FindAll(m => m == "cavid").Count;
//Console.WriteLine(result);
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


//L/*ist<int> numbers = new List<int>() { 1, 2, 3, 4 };*/
//Console.WriteLine(numbers.Sum(m=>m));
/*C*//*onsole.WriteLine(numbers.FindAll(m=>m%2==0).Sum(m=>m));*/

//var sum = numbers.FindAll(m => m % 2 == 0).Sum(m => m);

//Console.WriteLine(sum);
//var res = numbers.FindAll(m => m % 2 == 0);
//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}
//int sum1 = 0;
//foreach (var item in res)
//{
//    sum1 += item;
//    Console.WriteLine(sum1);
//}


List<Student> students = new List<Student>();

Student stu1 = new Student
{

    Id = 1,
    FullName= "ROYA MEHERREMOVA",
    Age =26,
    Address= "Sumqayit"



};


Student stu2 = new Student
{

    Id = 2,
    FullName = "ferid abdullayev",
    Age = 17,
    Address = "nesimi"




};


Student stu3 = new Student
{

    Id = 3,
    FullName = "shaiq kazimov",
    Age = 25,
    Address = "sedmoy"



};

foreach (var item in students)
{
    Console.WriteLine(item.FullName);


}


//Console.WriteLine("Add full name");
//string fullName = Console.ReadLine();
//Console.WriteLine("add address");
//string address = Console.ReadLine();
//Console.WriteLine("add age");
//int age = Convert.ToInt32(Console.ReadLine());



//Student student = new Student
//{
//    Id = 1,
//    FullName=fullName,
//    Address=address,
//    Age=age



//};
//AddStudent(student);


//Console.WriteLine("ADD FULL NAME");
//string fullname = Console.ReadLine();
//Console.WriteLine("Add Address");
//string address = Console.ReadLine();
//Console.WriteLine("ADD AGE");
//int age =Convert.ToInt32(Console.ReadLine());


//Student student = new Student
//{
//    Id= 1,
//    FullName=fullname,
//    Address=address,
//    Age = age

//};
//AddStudent(student);


Console.WriteLine("add full name");
string fullnames =Console.ReadLine();
Console.WriteLine("add address");
string addresss =Console.ReadLine();
Console.WriteLine("add age");
int ages= Convert.ToInt32(Console.ReadLine());

Student student = new Student
{
    Id = 1,
    FullName = fullnames,
    Address = addresss,
    Age = ages

};





//static void AddStudent(Student student)
//{

//    List<Student> students = new();
//    students.Add(student);
//    foreach (var item in students)
//    {
//        Console.WriteLine(item.FullName);
//    }




//}


//static void AddStudent(Student student)
//{
//    List<Student> students = new List<Student>();
//    students.Add(student);

//    foreach (var item in students)
//    {
//        Console.WriteLine(item.FullName);
//    }
//}



static void AddStudent(Student student)
{
    List<Student> students = new List<Student>();
    students.Add(student);

    foreach (var item in students)
    {
        Console.WriteLine(item.FullName);
    }
}

SortedList<int, string> datas = new SortedList<int, string>();
datas.Add(2, "cavid");
datas.Add(1, "pervin");
foreach (KeyValuePair<int,string> item in datas)
{
    Console.WriteLine(item.Key+""+item.Value);
}


//HashSet<int> datas1 = new HashSet<int>();
//datas1.Add(1);
//datas1.Add(2);
//datas1.Add(5);
//foreach (var item in datas1)
//{
//    Console.WriteLine(item);
//}




//Stack<string> stack = new Stack<string>();
//stack.Push("salam");
//stack.Push("sagol");

//foreach (var item in stack)
//{
//    Console.WriteLine(item);
//}


//Queue<string> queue = new Queue<string>();
//queue.Enqueue("salam");

//queue.Enqueue("sagol");
//queue.Enqueue("xxx");
//foreach (var item in queue)
//{
//    Console.WriteLine(item);



//}


//Dictionary<string, string> datas3= new Dictionary<string, string>();
//datas3.Add("admin", "mirze");
//datas3.Add("member", "hacker");
//datas3.Add("superadmin", "anar");

//foreach (KeyValuePair<string, string> item in datas3) 
//{
//    if (item.Key == "admin")
//    {
//        Console.WriteLine(item.Value);
//    }
//}



