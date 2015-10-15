using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_paradygmaty
{
    using System;
 
abstract class Zoo
{
    abstract public void Breath();
}
 
class Demon : Zoo
{
    public override void Breath()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Pierwsze labki z programowania obiektowego");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("dowiedzialem sie ze c# lepszy od c++");
    }
}
 
static class boo
{
    static public int asd;
    static public int qwe
    {
        get
        {
            return asd ;
        }
        set
        {
            asd = value;
        }
    }
}
 
class Program
{
 
    static void Main(string[] args)
    {
 
        boo.qwe = 5;
        Console.WriteLine(boo.asd + boo.qwe);
 
        Zoo MyZoo = new Demon();
        MyZoo.Breath();
        Console.ReadLine();
    }
}
    
}
