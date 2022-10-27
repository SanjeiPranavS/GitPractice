using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace BindingStatement.Observable
{
    public class ColorDescriptor : ObservableObject
    {
        public ColorDescriptor(Color color, string name)
        {
            Color = color;
            Name = name;
        }

        public Color Color { get; private set; }

        public string Name { get; private set; }

        public override string ToString()
        {
            return $"{Name} (#{Color.R:X2}{Color.G:X2}{Color.B:X2})";
        }
    }
}
