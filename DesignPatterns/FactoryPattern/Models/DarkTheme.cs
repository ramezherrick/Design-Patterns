using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Models
{
    public class DarkTheme : ITheme
    {
        public string BackGroundColor => "black";

        public string TextColor => "white";
    }
}
