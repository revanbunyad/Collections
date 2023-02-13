using Collections.Classs;
using System.Runtime.CompilerServices;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ArrayList
            //ArrayList arrayList = new ArrayList();
            //Student student = new Student("Nahid");
            //Student student2 = new Student("Revan");
            //Student student3 = new Student("Nicat");
            //arrayList.Add(5);
            //arrayList.Add(true);
            //arrayList.Add("Test");
            //arrayList.Add(student);
            //arrayList.Add(new int []{5,5,5,15 });

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            // Hastable

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(1, "Test");
            //hashtable.Add("key", true);
            //hashtable.Add("alpha", student);
            //hashtable.Add(2, "Test 2");

            //foreach (var item in hashtable.Keys)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in hashtable.Values)
            //{
            //    Console.WriteLine(item);
            //}

            // Lists

            //List<Student> students= new List<Student>();
            //students.Add(student);
            //students.Add(student2);
            //students.Add(student3);

            //students.Remove(student);
            //foreach (Student stu in students)
            //{
            //    Console.WriteLine(stu);
            //}

            //List<int> numbers = new List<int>();
            //numbers.AddRange(new int[] { 3, 5, 7, 8, -2, 4, 2, 12 });
            //numbers.Clear();
            //numbers.RemoveAt(1);
            //numbers.RemoveRange(1, 2);
            //numbers.Sort();
            //numbers.Reverse();

            //numbers.Insert(1, 5);
            //foreach (int number in numbers)
            //{
            //    if (number > 10)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //Console.WriteLine(numbers.Contains(5));

            //Console.WriteLine(numbers.First());
            //Console.WriteLine(numbers.IndexOf(10));

            //foreach (int number in numbers.Skip(2).Take(4))
            //{
            //    Console.WriteLine(number);
            //}

            //Dictionary<string,string> phoneNumbers = new Dictionary<string,string>();
            //phoneNumbers.Add("+994", "az");
            //phoneNumbers.Add("+90", "tr");
            //phoneNumbers.Add("+7", "ru");
            //phoneNumbers.Add("+995", "ge");

            //foreach (KeyValuePair<string,string> kvp in phoneNumbers)
            //{
            //    Console.WriteLine($"Key - {kvp.Key}");
            //    Console.WriteLine($"Value - {kvp.Value}");
            //}

            //SortedList<string, string> phoneNumbers = new SortedList<string, string>();
            //phoneNumbers.Add("+994", "az");
            //phoneNumbers.Add("+90", "tr");
            //phoneNumbers.Add("+7", "ru");
            //phoneNumbers.Add("+995", "ge");

            //foreach (KeyValuePair<string,string> keyValuePair in phoneNumbers)
            //{
            //    Console.WriteLine(keyValuePair.Key);
            //}

            //Stack<int> stack = new Stack<int>();
            //Stack stack2 = new Stack();
            //stack.Push(1);
            //stack2.Push("sdgjfb;");
            //stack2.Push(3);
            //Console.WriteLine(stack2.Peek());
            //stack2.Pop();

            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue("ok");
            //Console.WriteLine(queue.Peek());
            //Console.WriteLine(queue.Dequeue());

            //foreach (string item in stack2)
            //{
            //    Console.WriteLine(item);
            //            
        }

        static void Main1(string[] args)
        {

            Product products1 = new Product(1,"BMW", "Almaniya", 35000);
            Product products2 = new Product(2,"Mercedes", "Almaniya", 13000);
            Product products3= new Product(3,"Lada", "Rusiya", 9800);
            Product products4= new Product(4,"Bentley", "Ingiltere", 85000);

            Category category = new Category("Masin");

            category.AddProduct(products1);
            category.AddProduct(products2);
            category.AddProduct(products3);
            category.AddProduct(products4);
            
            category.RemoveProduct(products1);

            category.GetFullInfo();

            








        }
          

        }
    }
