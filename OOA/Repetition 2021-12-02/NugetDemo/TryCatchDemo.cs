using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetDemo
{
    public class TryCatchDemo
    {
        public void Crash()
        {
            int x = 0;
            int y = 0;
            int s = 0;
            
            try
            {
                s = x / y;
            }
            catch (DivideByZeroException ex)
            {
                System.Diagnostics.Debug.WriteLine("Försökte dela med 0!!!!");
                throw; // <--- OK!

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw; // <--- OK!
                //throw ex; // <-- Fy skäms!
            }
            finally
            {
                // Rensa upp i alla objekt
                // Ex. Skrivare, databas mm
                // Sätt objekten till null eller kör close eller nåt
            }


        }
    }
}
