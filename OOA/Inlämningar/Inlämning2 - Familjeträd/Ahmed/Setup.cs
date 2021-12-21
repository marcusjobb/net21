using Inlämning2.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inlämning2.Models;

namespace Inlämning2
{
    public static class Setup
    {
        public static void Init()
        {

            var context = new GenealogiLogic();
            // clear database
            context.Clear();
            // Create the stark family
            var starkFirstGen = new List<Person>
                {
                    new Person ("Rickard", "Stark", "240 AC", "282 AC"),
                    new Person ("Lyarra", "Stark", "245 AC", "290 AC")
                };
            context.Create(starkFirstGen);

            // Add parents to each member

            var starkSecGen = new List<Person>
            {
                    new Person ("Brandon", "Stark", "262 AC", "282 AC"),
                    new Person ("Ned", "Stark", "263 AC", "299 AC"),
                    new Person ("Lyanna", "Stark", "267 AC", "283 AC"),
                    new Person ("Benjen", "Stark", "268 AC"),
                    new Person ("Caitlyn", "Tully", "264 AC", "300 AC")
            };

            context.Create(starkSecGen);


            var rickard = context.Read("rickard");
            var lyarra = context.Read("lyarra");

            foreach (var child in starkSecGen)
            {
                if (child.LastName == "Stark")
                {
                    context.SetFather(child.ID, rickard.ID);
                    context.SetMother(child.ID, lyarra.ID);
                }
            }

            var ned = context.Read("ned");
            var caitlyn = context.Read("caitlyn");
            var lyanna = context.Read("lyanna");


            var starkThirdGen = new List<Person>
            {
                    new Person ("Rob", "Stark", "283 AC", "300 AC"),
                    new Person ("Jon", "Snow", "283 AC"),
                    new Person ("Sansa", "Stark", "286 AC"),
                    new Person ("Arya", "Stark", "289 AC"),
                    new Person ("Bran", "Stark", "290 AC"),
                    new Person ("Rickon", "Stark", "295 AC", "304 AC"),
                    new Person ("Ahmed", "Stark", "296 AC", "304 AC")
            };
            context.Create(starkThirdGen);

            foreach (var child in starkThirdGen)
            {
                if (child.LastName == "Stark")
                {
                    context.SetFather(child.ID, ned.ID);
                    context.SetMother(child.ID, caitlyn.ID);
                }
                else
                {
                    context.SetMother(child.ID, lyanna.ID);
                }
            }

            // Remove the imposter that is not part of the stark family
            var ahmed = context.Read("ahmed");
            if (ahmed != null)
            {
                context.Delete(ahmed.ID);
            }
            // Lista ut efter lastname

            var everyone = context.List("lastName");

            foreach (var individual in everyone)
            {
                Console.WriteLine(individual.FirstName +" "+ individual.LastName);
            }

            // Visa Anfader/Anmoder till "Benjen Stark"
            var benjen = context.Read("benjen");
            if(benjen != null)
            {
               var father = context.GetFather(benjen.ID);
                var mother = context.GetMother(benjen.ID);
                Console.WriteLine("Benjens Parents");
                Console.WriteLine(mother.FirstName + " And " +father.FirstName + " " + father.LastName);
                
            }
        }
    }
}
