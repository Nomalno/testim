using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace testim
{
    class PersonRepositoriy
    {


        private Dictionary<int, string> fakedb = new Dictionary<int, string>()
            {
            {1,"FirstTask" },
            {2,"Test" },
            {3,"db" },
            {4,"Zadanie" },
            {5,"GamePrj" },
            {6,"tkm" }
            };

        internal void GetAll()
        {
            Console.WriteLine("Repositories Avaible:");
            for (int i = 1; i <= fakedb.Count; i++)
                if (fakedb.ContainsKey(i))
                    Console.WriteLine(fakedb[i]);
            Console.WriteLine();
            return;

        }
        internal void Insert(string value)
        {
            int length=fakedb.Count;
            Console.WriteLine("*Adding*");
            fakedb.Add(length+1, value);
            Console.WriteLine("You Added:" + fakedb[length+1]);
            Console.WriteLine();

        }
        internal void GetById()
        {
            Console.Write("Repositoriy id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Searching...");
            Thread.Sleep(1500);
            Console.WriteLine(fakedb[id]);
            Console.WriteLine();
            return;
        }

        internal void Delete(int id)
        {
            Console.WriteLine("*Deleted*");
            {
                fakedb.Remove(id);
                for (int i = 1; i <= fakedb.Count; i++)
                {
                    if (id != fakedb.Count)
                    {
                        fakedb[id]=fakedb[id-2];
                    }
                }
            }
            Console.WriteLine();
        }

        internal void Update(int id, string title)    
        {
            Console.WriteLine("*Update*");
            fakedb.Remove(id);
            fakedb.Add(id,title);
            Console.WriteLine();
        }
        internal void Find(int count)
        {
            Console.WriteLine($"Количество символов в названии, которое больше, либо равно{count}");
            for (int i = 1; i <= fakedb.Count; i++)
            {
                if (fakedb[i].Length>=count)
                {
                    Console.WriteLine(fakedb[i]);
                }
            }
            Console.WriteLine();
            return;
        }
    }







}
 

//GetAll - возвращает все элементы коллекции
//GetById - возвращает элемент по заданному id
//Insert - Добавляет элемент в коллекцию
//Delete - Удаляет элемент из коллекции
//Update - Обновляет элемент коллекции 
//Find - возвращает список элементов по заданному условию (Для условия можно использовать любое поле обьекта)
