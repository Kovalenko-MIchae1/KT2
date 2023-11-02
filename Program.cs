using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class overload1
    {
        public int x, y, z;

        public overload1(int x = 0, int y = 0, int z = 0) 
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static bool operator ==(overload1 obj1, overload1 obj2) 
        {
            if ((obj1.x == obj2.x) && (obj1.y == obj2.y) && (obj1.z == obj2.z))
            return true;
            return false;
        }

        public static bool operator !=(overload1 obj1, overload1 obj2) 
        {
            if ((obj1.x != obj2.x) || (obj1.y != obj2.y) || (obj1.z != obj2.z)) 
            return false;
            return true;
        }
    }

   



    class Programm
    {
        static void Main(string[] args)
        {
        overload1 myObject1 = new overload1(x: 3, z: 10, y: 17);
        overload1 myObject2 = new overload1(x: 3, z: 10, y: 17);
            overload2 myObject3 = new overload2(a: 5, c: 16, b: 19);

        if (myObject1 == myObject2)
            Console.WriteLine("Объекты равны");
            if (myObject3)
                Console.WriteLine("Все координаты объекта myObject3 положительны");
        Console.ReadLine();
        }
    }

    class overload2
    {
        public int a, b, c;

        public overload2(int a = 0, int b = 0, int c = 0) 
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }


        public static bool operator false(overload2 obj)
        {
            if ((obj.a <= 0) || (obj.b <= 0) || (obj.c <= 0))
            return true;
            return false;
        }

        public static bool operator true(overload2 obj)
        {
            if ((obj.a > 0) && (obj.b > 0) && (obj.c > 0))
            return true;
            return false;
        }
    }
}
