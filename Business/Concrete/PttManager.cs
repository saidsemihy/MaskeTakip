using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        private IApplicantService _applicantService;
        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        } //Constructor new yapıldığında çalışır
        public void GiveMask(Person person)
        {
            //PersonManager personManager = new PersonManager();
            //if (personManager.CheckPerson(person))
            //{
            //    Console.WriteLine(person.FirstName + " " + person.LastName + " için maske verildi");
            //}
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " için maske verilemedi");
            }
        }
    }
}
