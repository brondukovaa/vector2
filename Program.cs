
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    public struct Vector
    {
        public float X=100
        public float y =120
        public float dt = 1/60
        public float a
        public float v
        public float g

        public override string ToString() => "{x}, {y}";
        Vector x = new Vector(0, 0)
        Vector V = new Vector(x, y)
        Vector g = new Vector(0, -10)
        while(x.y>0){
            V+=g* dt
            x+=V* dt
            Console.WrileLine(x) }

        
       
    }
}