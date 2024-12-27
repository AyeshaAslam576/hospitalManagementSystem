using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HopitalSystem.BussinessLayer
{
    public class Person
    {
        public string Name { get; set; }
        public string P_Adress { get; set; }
        public BigInteger Contact { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Blood_Group { get; set; }
        public string Disease { get; set; }
        public int PIDD { get; set; }
        public string Symptoms { get; set; }
        public string Medicines { get; set; }
        public string Ward { get; set; }
        public string Ward_Type { get; set; }

        public Person()
        {

        }
        public Person(string name, string adress, BigInteger contact, int age, string gender)
        {

            Name = name;
            P_Adress = adress;
            Contact = contact;
            Age = age;
            Gender = gender;
           
        }
      
    }
}
