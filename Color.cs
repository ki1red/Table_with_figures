using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    [Serializable]
    public class Color
    {
        private int red;
        private int green;
        private int blue;

        private int transparency;

        // Конструктор с параметрам
        public Color(int _red, int _green, int _blue, int _transparency)
        {
            this.red = _red;
            this.green = _green;
            this.blue = _blue;
            this.transparency = _transparency;

            if (_red > 255 || _red < 0) this.red = 0;
            if (_green > 255 || _green < 0) this.green = 0;
            if (_blue > 255 || _blue < 0) this.blue = 0;
            if (_transparency > 255 || _transparency < 0) this.transparency = 0;
        }

        // Изменение цвета и прозрачности
        public bool SetNewOptions(int red, int green, int blue, int transparency)
        {
            if (red > 255 || red < 0) return false;
            if (green > 255 || green < 0) return false;
            if (blue > 255 || blue < 0) return false;
            if (transparency > 255 || transparency < 0) return false;

            this.red = red;
            this.green = green;
            this.blue = blue;
            this.transparency = transparency;

            return true;
        }

        // Узнать сочность красного
        public int GetRed()
        {
            return this.red;
        }

        // Узнать сочность зелёного
        public int GetGreen()
        {
            return this.green;
        }

        // Узнать сочность синегго
        public int GetBlue()
        {
            return this.blue;
        }

        // Узнать непрозрачность
        public int GetTransparency()
        {
            return this.transparency;
        }
    }
}
