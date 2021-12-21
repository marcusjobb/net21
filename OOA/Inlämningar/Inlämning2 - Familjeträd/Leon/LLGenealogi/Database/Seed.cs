using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LLGenealogi.Models;

namespace LLGenealogi.Database
{
    internal static class Seed
    {
        public static void Start()
        {
            Person person1 = new Person();
            Person person2 = new Person();
            CRUD crud = new CRUD();
            // FORMAT: PERSON, MOTHER, FATHER

            // JACK SCHITT, NOET SCHITT, NOE SCHITT
            person1.Name = "Jack";
            person1.LastName = "Schitt";
            crud.Create(person1);

            person1 = new Person();
            person1.Name = "Noet";
            person1.LastName = "Schitt";
            crud.Create(person1);

            person1 = new Person();
            person1.Name = "Noe";
            person1.LastName = "Schitt";
            crud.Create(person1);
            // NOET SCHITT, AWET SCHITT, AWE SCHITT'
            person1 = new Person();
            person1.Name = "Awet";
            person1.LastName = "Schitt";
            crud.Create(person1);

            person1 = new Person();
            person1.Name = "Awe";
            person1.LastName = "Schitt";
            crud.Create(person1);
            // NOE SCHITT, FULLET SCHITT, FULLE SCHITT
            person1 = new Person();
            person1.Name = "Fullet";
            person1.LastName = "Schitt";
            crud.Create(person1);

            person1 = new Person();
            person1.Name = "Fulle";
            person1.LastName = "Schitt";
            crud.Create(person1);

            // Jack Parents
            person1 = new Person();
            person2 = new Person();
            person1 = crud.Read("Jack");
            person2 = crud.Read("Noet");

            person1.Mor = person2.Id;
            person2 = new Person();
            person2 = crud.Read("Noe");
            person1.Far = person2.Id;

            // Noet Parents
            person1 = new Person();
            person2 = new Person();
            person1 = crud.Read("Noet");
            person2 = crud.Read("Awet");


            person1.Mor = person2.Id;
            person2 = new Person();
            person2 = crud.Read("Awe");
            person1.Far = person2.Id;

            // Noe Parents
            person1 = new Person();
            person2 = new Person();
            person1 = crud.Read("Noe");
            person2 = crud.Read("Fullet");

            person1.Mor = person2.Id;
            person2 = new Person();
            person2 = crud.Read("Fulle");
            person1.Far = person2.Id;

            //
            crud.Save();
            Thread.Sleep(3000);
            LLGenealogi.Menus.MenuMain.Start();
        }
    }
}
