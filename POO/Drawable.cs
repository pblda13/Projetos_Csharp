using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
   abstract class Drawable  //Se precisar usar metodos e atributos usar abstract
    {
        public int Size;
        public string color;
        public abstract void Draw();
    }
}
