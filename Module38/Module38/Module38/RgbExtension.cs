using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module38
{
    public class RgbExtension : IMarkupExtension
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            // Генерация цвета по цифровым значениям (красный, зеленый, синий)
            return Color.FromRgb(Red, Green, Blue);
        }
    }
}
