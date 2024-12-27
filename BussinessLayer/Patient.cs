using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HopitalSystem.BussinessLayer
{
    public  class Patient:Person
    {


        public  string Blood_Group { get; set; }
        public  string Disease { get; set; }
        public  int PIDD { get; set; }
        public  string Symptoms { get; set; }
        public  string Medicines { get; set; }
        public  string Ward { get; set; }
        public  string Ward_Type { get; set; }
       
        public Patient()
        {
             
        }
        public Patient(string name,string adress,BigInteger contact,int age,string gender,string BloodGroup,string disease):base(name,adress,contact,age,gender)
        {
           
         
            Blood_Group = BloodGroup;
            Disease = disease;
        }
        public Patient(int id, string symptoms, string medicines, string ward, string wardType)
        {
            PIDD = id;
            Symptoms = symptoms;
            Medicines = medicines;
            Ward = ward;
            Ward_Type = wardType;

        }

    }
}
