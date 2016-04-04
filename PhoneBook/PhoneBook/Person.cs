using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public struct Person
    {
        string name;
        string address;
        int age;
        int telephone;
        Type type;

        public Person(string name,string address,int age,int telephone,Type type)
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.telephone = telephone;
            this.type = type;
        }

        public override string ToString()
        {
            return (String.Format("Name:{0}   Address:{1}   Age:{2}   Telephone:{3}   Type:{4}",name,address,age,telephone,type));
        }

    }
}
