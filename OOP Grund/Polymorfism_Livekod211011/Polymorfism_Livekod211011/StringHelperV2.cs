namespace Polymorfism_Livekod211011
{
    partial class Program
    {
        public class StringHelperV2:StringHelper
        {
            public override int ToInt(string text)
            {
                text += "1";
                return base.ToInt(text);
            }

            public string CleanUp(string text)
            {
                return text.Replace("  ", " ").Trim();
            }
        }
             
    }
}
