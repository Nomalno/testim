using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testim
{
     class Person
    {
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public Person(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public void PersonJ()
        {
            Console.WriteLine("Пользователь:  "  +  Name  +  ("  Id: ") +  ( id));
        }
    }
}
