using System.Diagnostics;
using System.Net;
using System.Xml.Linq;

namespace CS_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Описать структуру Article, содержащую следующие поля:
            // код товара; название товара; цену товара.
            Console.WriteLine("Task 1.");
            Article article = new Article();
            article.Input();
            Console.WriteLine("---------------------------------");
            article.Print();

            Console.WriteLine("---------------------------------");
            // использование конструктора с параметрамми
            Article article1 = new Article(5, "Marker", 350);
            article1.Print();

            // 2.Описать структуру Client содержащую поля:
            // код клиента; ФИО; адрес; телефон;
            // количество заказов осуществленных клиентом;
            // общая сумма заказов клиента.
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Task 2.");
            Client client = new Client();
            client.Input();
            Console.WriteLine("---------------------------------");
            client.Print();

            // 3.Описать структуру RequestItem содержащую поля: 
            // товар; количество единиц товара
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Task 3.");
            RequestItem requestItem = new RequestItem();
            requestItem.Input();
            Console.WriteLine("---------------------------------");
            requestItem.Print();
        }
    }

    // структура Article
    public struct Article
    {
        public int ProductId;
        public string Name;
        public double Price;

        public Article(int id, string name, double price)
        {
            ProductId = id;
            Name = name;
            Price = price;
        }

        public void Print()
        {
            Console.WriteLine("Information (struct Article):");
            Console.WriteLine("Product id: " + ProductId);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Price: " + Price + " KZT");
        }

        public void Input()
        {
            Console.Write("Enter the product id: ");
            ProductId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter name: ");
            Name = Console.ReadLine();
            Console.Write("Enter price: ");
            Price = Convert.ToDouble(Console.ReadLine());
        }
    }

    // структура Client
    public struct Client
    {
        public int ClientId;
        public string FIO;
        public string Address;
        public int PhoneNumber;
        public int NumOfOrders;
        public double TotalSum;

        public Client(int id, string fio, string address, int phoneNum, int orders, double totalSum)
        {
            ClientId = id;
            FIO = fio;
            Address = address;
            PhoneNumber = phoneNum;
            NumOfOrders = orders;
            TotalSum = totalSum;
        }

        public void Print()
        {
            Console.WriteLine("Information (struct Client):");
            Console.WriteLine("Clinet id: " + ClientId);
            Console.WriteLine("FIO: " + FIO);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Phone Number: " + PhoneNumber);
            Console.WriteLine("Number of Orders: " + NumOfOrders);
            Console.WriteLine("Total Sum: " + TotalSum + " KZT");
        }

        public void Input()
        {
            Console.Write("Enter the client id: ");
            ClientId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter FIO: ");
            FIO = Console.ReadLine();
            Console.Write("Enter address: ");
            Address = Console.ReadLine();
            Console.Write("Enter the phone number: ");
            PhoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of orders: ");
            NumOfOrders = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter total sum: ");
            TotalSum = Convert.ToDouble(Console.ReadLine());
        }
    }

    // структура RequestItem
    public struct RequestItem
    {
        public string Name;
        public int Quantity;

        public RequestItem(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public void Print()
        {
            Console.WriteLine("Information (struct RequestItem):");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Quantity: " + Quantity);
        }

        public void Input()
        {
            Console.Write("Enter name: ");
            Name = Console.ReadLine();
            Console.Write("Enter quantity: ");
            Quantity = Convert.ToInt32(Console.ReadLine());
        }
    }
}