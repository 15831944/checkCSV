using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace checkGA
{
    static class ABI
    {
        public static string hasDashAtEnd(string path)
        {
            if (path.EndsWith(@"\"))
            {
                path = path.Remove(path.Length - 1);
            }
            return path;
        }

        public static Color colorOfField(GA_Data ga)
        {
            if (ga.status == 1)
            {
                return Color.LimeGreen;
            }
            else if (ga.status == 2)
            {
                return Color.Red;
            }
            else
            {
                return Color.Cyan;
            }
        }
    }
}
