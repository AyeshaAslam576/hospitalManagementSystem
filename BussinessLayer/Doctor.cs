using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HopitalSystem.BussinessLayer
{
    internal class Doctor:Person
    {
       
        public string Qualification { get; set; }
        public int Sid { get; set; }
        public Doctor(string name, string adress, BigInteger contact, int age, string gender, int id, string qualification)
        {
            Sid = id;
           
            Qualification = qualification;
        }
    }
}
