using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement17
{

    class Patient
    {

        private string name, gender, medicalHistory, symptomCode, prescription;
        private int age;
        public  string errorMessage;

        public string GetName() { 
                    return this.name;
                         }
        public string GetGender() { 
                    return this.gender;
                         }
        public string GetMedicalHistory() { 
                    return this.medicalHistory;
                         }
        public string GetSymptomCode() { 
                    return this.symptomCode;
                         }
        public string GetPrescription() { 
                    return this.prescription;
                         }
        public int GetAge() { 
                    return this.age;
                         }
        public bool SetName(string name) 
                    {
                        if (name == null) {
                            return false;
                        }
                        this.name=name;
                        return true;
                    }
        public bool SetGender(string gender)
        {
            if (gender == null)
            {
                return false;
            }
            this.gender = gender;
            return true;
        }
        public void SetMedicalHistoy(string medicalHistory)
        {
            this.medicalHistory = medicalHistory;
        }
        public bool SetSymptomCode(string symptomCode)
        {
            if (symptomCode == null)
            {
                return false;
            }
            this.symptomCode = symptomCode;
            return true;
        }
        public void SetPrescription(string prescription)
        {
            this.prescription = prescription;
        }
        public bool SetAge(int age)
        {
            if (age <=0|age>100)
            {
                return false;
            }
            this.age = age;
            return true;
        }
  
    }
    class Program
    {
        static void Main(string[] args)
        {

            Patient obj1 = new Patient();
            Console.WriteLine("Hi, I'm Bob. I'm here to help you in your medication.");
            Console.WriteLine("Enter Patient Name:");
            obj1.SetName(Console.ReadLine());
            Console.WriteLine("Enter Patient Age:");
            obj1.SetAge(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter Patient Gender:");
            obj1.SetGender(Console.ReadLine());
            Console.WriteLine("Enter Medical History. Eg: Diabetes. Press Enter for None:");
            obj1.SetMedicalHistoy(Console.ReadLine());
            int a = (int)293.34;
            /*
             * 


Enter your (patient) details:

 William

 30

 Male

 Diabetes
             */
        }
    }
}
