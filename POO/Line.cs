using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    class Line : Drawable
    {
        public float Area()
        {
            return 20;
        }

       // public void Draw()
        //{
         //   Console.WriteLine("Linha");
       // }

        public override void Draw()
        {
            
        }
    }

    class Quad : IDrawable
    {
        public float Area()
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }

    class Rect : IDrawable
    {
        public float Area()
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
