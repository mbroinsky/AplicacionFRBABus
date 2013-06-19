﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FrbaBus.Utilidades
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
            Regex regex = new Regex("[A-Z]{3}-[0-9]{3}");
            return regex.IsMatch(text);
        }

        internal static bool esNumeroReal(String text)
        {
            Regex regex = new Regex("^\\d+\\.?\\d{1,2}$" );
            return regex.IsMatch(text);
        }
        
        internal static bool esFechaValida(String text)
        {
            Regex regex = new Regex("^201[0-9]\\-[0][1-9]|[1][0-2]\\-\\[0-2][0-9]|[3][0-1] [0-1][0-9]|[2][0-3]\\:[0-5][0-9]\\:[0-5][0-9]$");
            return regex.IsMatch(text);
        }

        internal static bool esHoraValida(String text)
        {
            Regex regex = new Regex("^[0-1][0-9]|[2][0-3]:[0-5][0-9]$");
            return regex.IsMatch(text);
        }

    }
}
