using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCS
{
    internal class distancia : datos
    {
        public distancia(double x1, double y1, double x2, double y2) : base(x1, y1)
        {
            double x = x2 - x1;
            double y = y2 - y1;
            Interaction.MsgBox("La distancia entre 2 puntos es: " + Math.Sqrt(x * x + y * y), MsgBoxStyle.Information, "Sistema");
        }
    }
}
