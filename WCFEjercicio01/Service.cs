using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFEjercicio01.Model;

namespace WCFEjercicio01
{
    public class Service : IService
    {
        public Person getByDNI(string dni)
        {
            using (Ejercicio01Entities a = new Ejercicio01Entities())
            {
                return a.Person.Where(x => x.DNI == dni).FirstOrDefault();
            }
        }

        public Person updateByDNI(Person p)
        {
            using (Ejercicio01Entities a = new Ejercicio01Entities())
            {
                var aux = a.Person.Where(x => x.DNI == p.DNI).FirstOrDefault();

                aux.Age = p.Age;
                aux.Capital_gain = p.Capital_gain;
                aux.Capital_loss = p.Capital_loss;
                aux.Country = p.Country;
                aux.Education = p.Education;
                aux.Education_num = p.Education_num;
                aux.Fnlwgt = p.Fnlwgt;
                aux.Hours_per_week = p.Hours_per_week;
                aux.Id_Sex = p.Id_Sex;
                aux.Id_Status = p.Id_Status;
                aux.Occupation = p.Occupation;
                aux.Race = p.Race;
                aux.Relationship = p.Relationship;
                aux.Sex = p.Sex;
                aux.Status = p.Status;
                aux.Workclass = p.Workclass;

                a.SaveChanges();

                return aux;
            }
        }
    }
}
