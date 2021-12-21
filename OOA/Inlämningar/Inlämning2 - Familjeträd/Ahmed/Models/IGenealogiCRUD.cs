using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning2.Models
{
    interface IGenealogiCRUD
    {
        void Create(Person person);
        void Create(List<Person> people);
        void Delete(int Id);
        void Delete(string name);
        Person GetFather(int Id);
        Person GetMother(int Id);
        void SetFather(int offspringId, int fatherId);
        void SetMother(int offspringId, int motherId);
        List<Person> GetOffsprings(int Id);
        List<Person> List(string filter = "firstName");
        Person Read(string name);
        Person Read(int Id);
        void Update(Person person);
        void Clear();
    }
}
