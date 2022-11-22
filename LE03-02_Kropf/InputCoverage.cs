using System;
using System.Windows.Forms;

namespace LE03_02_Kropf
{
    internal class InputCoverage
    {
        public static int IntRequest() //absicherung
        {
            while (true)
            {
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Fehlermeldung");
                }
            }
        }
    }
}
