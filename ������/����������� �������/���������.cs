using System;
using System.Collections.Generic;
using System.Text;

namespace Телега.Графические_объекты
{
    static class Параметры
    {
        public static double Скорость_движения = 1.5;
        public static double Приращение_угла = 0 - Math.PI * Скорость_движения / 180;
        public static int Высота_канвы;
        public static readonly int Смещение_по_Y = 40;
    }
}
