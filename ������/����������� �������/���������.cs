using System;
using System.Collections.Generic;
using System.Text;

namespace Телега.Графические_объекты
{
    static class Параметры
    {
        public static System.Drawing.Color Цвет_левого_колеса;
        public static System.Drawing.Color Цвет_правого_колеса;
        public static System.Drawing.Color Цвет_телеги;
        public static double Скорость_движения = 1.5;
        public static double Приращение_угла = Math.PI * Скорость_движения / 180;
    }
}
