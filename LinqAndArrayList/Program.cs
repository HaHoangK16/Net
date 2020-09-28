using System;
using System.Collections;
using System.Linq;

namespace LinqAndArrayList
{
    class Program
    {
        private static object arrayList;

        static void Main(string[] args)
        {

            ArrayList arrayList = new ArrayList();
            Console.WriteLine("Danh sanh 5 nhan vien:");

            arrayList.Add(new Staff(1, "Nam",24));
            arrayList.Add(new Staff(2, "Kien", 21));
            arrayList.Add(new Staff(3, "Viet", 21));
            arrayList.Add(new Staff(4, "Hang", 23));
            arrayList.Add(new Staff(5, "Tien", 24));

            foreach (Staff staff in arrayList)
            {
                Console.WriteLine("ID: "+staff.ID+" Name: "+staff.Name + " Age: " + staff.Age);
            }

            var newArrayList = arrayList.OfType<Staff>();
            var Search = from name in newArrayList
                         where (name.Age < 24)
                         select name;
            var sapxep = from name in newArrayList
                         orderby name.Name
                         select name;
            Console.WriteLine("Danh sach nguoi co tuoi nho hon 24 :"); 
            foreach (var item in Search)
            {
                Console.WriteLine("ID :"+ item.ID+" Name : " + item.Name+" Age : "+ item.Age); 
            }
            Console.WriteLine("Sap xep theo ten :"); 
            foreach (var item in sapxep)
            {
                Console.WriteLine("ID :" + item.ID + " Name : " + item.Name + " Age : " + item.Age);
            }

        }
    }
}
