using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccination
{

    class Beneficiery
    { public int autoincrementRegno = 1001;
        public int RegNo { get; set; }

        public string MemberName { get; set; }
        public long MobileNum { get; set; }

        public string Address { get; set; }

        public int Age { get; set; }
        public String City { get; set; }

        public string Gender { get; set; }
        public string VaccinationDetails { get; set; }

         autoincrementRegno++;
            
        
            public Beneficiery(int regno, string membername, long mobilenum, string address, int age, string gender)
            {
            this.RegNo = regno;
            this.MemberName = membername;
            this.MobileNum = mobilenum;
            this.Address = address;
            this.Age = age;
            this.Gender = gender;
            }

        //public void Dosetype()
        //{
        //    Console.WriteLine("Enter the vaccination type from below");
        //    Console.WriteLine("------------------------------------");
        //    Console.WriteLine("1.CovidShield");
        //    Console.WriteLine("2.Covaxin");
        //    Console.WriteLine("3.Sputnik");
        //    Console.WriteLine("------------------------------------");
        //    int option = int.Parse(Console.ReadLine());
        //    if (option == 1)
        //    {
        //        Console.WriteLine("You selected CovidShield");


        //    }
        //    else if (option == 2)
        //    {
        //        Console.WriteLine("You selected Covaxin ");

        //    }

        //    else
        //        Console.WriteLine("You have selected Sputnik");
        //}


        VaccinationDetails objvaccinedetail = new VaccinationDetails();
        public int Getvaccinedetail()
        {
            int dosage;
           
            dosage=int.Parse(Console.ReadLine());

        }
        public int Nextduedate()
        {
            if (dosage == 1)
            {
                if (Age > 18)
                { 
                Console.WriteLine("Your next dosage{",);
                }
        }
            else 
            {
                Console.WriteLine("You have completed the vaccination course.Thanks for your participlation in the drive");
            }
        }
        List<VaccinationDetails> vaccinedetail = new <VaccinationDetails> ();
        vaccinedetail.Add(objvaccinedetail);
        }


}
