// -----------------------------------------------------------------------------------------------
//  ClassLifetime.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace OOPDemo2
{
    internal class ClassLifetime
    {
        int value = 0;

        // property
        public int Value
        {
            get { return value; }
            set
            {
                if (value > 50) this.value = 50;
                else if (value < 0) this.value = 0;
                else
                    this.value = value;
            }
        }

        //public void SetValue(int v)
        //{
        //    if (v > 50) v = 50;
        //    if (v < 0) v = 0;
        //    value = v;
        //}
        public int GetValue()
        {
            return value;
        }

        // Constructor
        public ClassLifetime()
        {
            System.Console.WriteLine("Klassen startar upp");
            Value = -10;
        }

        // Destructor
        ~ClassLifetime()
        {
            System.Console.WriteLine("Klassen dör");
        }
    }
}