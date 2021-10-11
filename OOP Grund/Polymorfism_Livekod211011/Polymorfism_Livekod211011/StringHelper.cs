namespace Polymorfism_Livekod211011
{
    partial class Program
    {
        public class StringHelper
        {
            public virtual int ToInt(string text)
            {
                int.TryParse(text, out int retVal);
                return retVal;
            }

            public virtual double ToDouble(string text)
            {
                double.TryParse(text, out double retVal);
                return retVal;
            }
        }
             
    }
}
