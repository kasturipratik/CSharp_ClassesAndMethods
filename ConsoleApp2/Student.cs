using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Student
    {
        private int id;
        private string name;
        private string address;
        private string phone;

        public Student() {
           
        }


        public Student(int id, string name, string address, string phone)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public int Id1 { get => id; set => id = value; }

        public override string ToString()
        {
            return "{ ID: " + id + " Name: " + name + " Address: " + address + " Phone: " + phone + " }";
        }

    }
}
