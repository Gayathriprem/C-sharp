using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccination
{
    class Program
    {
        List<Beneficiery> listbeneficiery = new List<Beneficiery>();
        static void Main(string[] args)
        {
            Beneficiery[] objbeneficiery = new Beneficiery();

            Console.WriteLine("-------------------------");
            Console.WriteLine("Get Vaccinated be Safe..!");
            Console.WriteLine("select the below options to carry on the process");
            Console.WriteLine("1.Beneficiery detail");
            Console.WriteLine("2.VaccinationDetails");
            Console.WriteLine("3.Exit");
            Console.WriteLine("-------------------------");
            int selectedoption = int.Parse(Console.ReadLine());
            int i = 0;
            do 
            { 
               
                if (selectedoption == 1)

                {
                Console.WriteLine("Enter your Registered Number");
                objbeneficiery.RegNo = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your Name");
                objbeneficiery[i].MemberName = Console.ReadLine();
                Console.WriteLine("Enter your PhoneNumber");
                objbeneficiery[i].MobileNum = long.Parse(Console.ReadLine());
                Console.WriteLine("Enter  your address");
                objbeneficiery[i].Address = Console.ReadLine();
                Console.WriteLine("Enter  Age");
                objbeneficiery[i].Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Gender");
                objbeneficiery[i].Gender = Console.ReadLine();
                Console.WriteLine("Enter City");
                objbeneficiery[i].City = Console.ReadLine();
                Console.WriteLine("Registration completed Successfully");
                listbeneficiery.Add(objbeneficiery);

                }


                else if (selectedoption == 2)
                {
                Console.WriteLine("Enter Registration Number");
                int BeneficieryNum = int.Parse(Console.ReadLine());
                if (BeneficieryNum == listbeneficiery.RegNo)
                {
                    Console.WriteLine("1.Take Vaccation");
                    Console.WriteLine("2.Vaccation History");
                    Console.WriteLine("3.Next Due Date");
                    Console.WriteLine("4.Exit");

                    int vaccinationoption = int.Parse(Console.ReadLine());
                    switch (vaccinationoption)
                    {
                        case 1:

                            Vaccinetype = Console.ReadLine();

                    }
                }


                }
                
            }while(selectedoption==1||selectedoption==2||selectedoption==3)
        }
    }
}
