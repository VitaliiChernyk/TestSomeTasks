using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace testSomeTasks
{
   public class Product
    {
        public Product() { }

        public Product(string Code, string Name)
        {
            this._Code = Code;
            this._Name = Name;
        }
        public string _Code { get; set; }

        public string _Name { get; set; }
    }

    class Program
    {

        static void Main(string[] args)
        {
            ICollection<string> strICollection = new List<string>();
            strICollection.Add("masha");
            strICollection.Add("dfgsdfgdfdsfsdfgsdf");
            int ICollectionCount = strICollection.Count;
            StringBuilder str = new StringBuilder();
            
            //ArrayList strArrayList = new ArrayList();
            //strArrayList.Add("masha");
            //strArrayList.Add(1);
            //strArrayList.Add(89.9);
            //strArrayList.Add(new Product("1001", "Chair"));
            //StringBuilder stringBuilder = new StringBuilder();
            //foreach (var item in strArrayList)
            //{
            //    Console.WriteLine(item);
            //    stringBuilder.Append(" , " + item);
            //}
            //Console.WriteLine(stringBuilder);
            //Console.WriteLine(new string('-', 40));
            //Hashtable objHashtable = new Hashtable();
            //objHashtable.Add("1001","Chair");
            //objHashtable.Add("1002","Sofa");
            //objHashtable.Add("1003","Carpet");
            //Console.WriteLine();
            //foreach (var item in objHashtable.Values)
            //{
            //    Console.WriteLine(item);
            //}
            //objHashtable.Remove("1002");
            //foreach (var item in objHashtable.Values)
            //{
            //    Console.WriteLine(item);
            //}
            //string[] strArray = new string[10];
            //for (int i = 0; i < strArray.Length; i++)
            //    strArray[i] = (i + 1).ToString();
            //this.ListBoxArray.DataSource = null;
            //this.ListBoxArray.Items.Clear();

            //this.ListBoxArray.DataSource = strArray;
            //this.ListBoxArray.DataBind();
            Console.ReadKey();
        }




    }
}
