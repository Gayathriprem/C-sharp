using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccination
{
    class VaccinationDetails
    {
        public enum vaccinename
        {
            Covidshield=1,
            Covaxin=2,
            Sputnik=3,
        }
      public int Dosage { get; set; }

     public DateTime VaccinatedDate { get; set; }
       
      public void getdosageinfo()
        {
            this.Dosage = Dosage;
            //this.VaccinationDate = VaccinationDate;
        }

       
    }
}
