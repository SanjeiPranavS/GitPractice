using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BindingStatement.ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static void Debug(this string word)
        {
            System.Diagnostics.Debug.WriteLine(word);
        }

    }
}
