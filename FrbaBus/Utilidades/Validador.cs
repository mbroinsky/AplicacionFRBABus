using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FrbaBus
{
    static class Validador
    {
        internal static bool esNumericoEnteroPositivo(String text)
        {
            Regex regex = new Regex("[0-9]");
            return regex.IsMatch(text);
        }

        internal static bool esPantenteValida(String text)
        {
            Regex regex = new Regex("[[A-Z]{3}|-|[0-9]{3}");
            return regex.IsMatch(text);
        }
    }
}
