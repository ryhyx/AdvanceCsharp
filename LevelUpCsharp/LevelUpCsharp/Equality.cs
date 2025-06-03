using System.Text;

namespace LevelUpCsharp
{
    public class Equality
    {
        public void EqualityInrefVSvalue()
        {
            int x;
            int y;
            x = 1;
            y = 1;
            if (x == y) { Console.WriteLine(" == make sense"); }
            else { Console.WriteLine(" == doesnt make sense"); }
            if (y.Equals(x)) { Console.WriteLine(".equal make sense"); }
            else { Console.WriteLine(".equal doesnt make sense"); }
            object a = x;
            object b = a;
            if (object.ReferenceEquals(a, b)) { Console.WriteLine("RefrenceEqual Make sense"); }
            else { Console.WriteLine("RefrenceEqual doesnt make sense"); }

            x = y;
            if (x == y) { Console.WriteLine(" == make sense after assiginig one object to another"); }
            else { Console.WriteLine(" == doesnt make sense after assiginig one object to another"); }
            object c = x;
            object d = c;
            if (object.ReferenceEquals(c, d)) { Console.WriteLine("RefrenceEqual Make sense after assiginig one object to another"); }
            else { Console.WriteLine("RefrenceEqual doesnt make sense after assiginig one object to another"); }

            StringBuilder x1 = new StringBuilder("Rih");
            StringBuilder x2 = new StringBuilder("Rih");

            if (x1 == x2) { Console.WriteLine(" == st make sense "); }
            else { Console.WriteLine(" == st doesnt make sense "); }

            if (object.ReferenceEquals(x1, x2)) { Console.WriteLine("st RefrenceEqual Make sense "); }
            else { Console.WriteLine(" st RefrenceEqual doesnt make sense "); }

            if (x1.Equals(x2)) { Console.WriteLine("st .equal make sense"); }
            else { Console.WriteLine("st .equal doesnt make sense"); }


            object? a1 = null;
            object? b2 = null;

            Console.WriteLine(object.Equals(a1, b2)); // true — string overrides Equals to compare value

            Console.WriteLine(a1?.Equals(b2));
            object x3 = new object();
            object y3 = new object();
            Console.WriteLine(object.Equals(x3, y3)); // false — default reference equality




        }


    }
}
