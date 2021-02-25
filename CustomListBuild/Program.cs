using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> custom = new CustomList<int>();
            custom.Add(2);
            custom.Add(3);
            custom.Add(4);
            custom.Remove(3);
            
        }
    }
}
