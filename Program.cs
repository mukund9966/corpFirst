using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class newClass {
        public string newFunc(string sname, string mname , string ename)
        {
            return sname + "  "+ mname+"  " + ename;
        } }
    internal class Program
    {
        static void Main(string[] args)
        {
            newClass nc = new newClass();
            Console.WriteLine(nc.newFunc("mukund","kumar", "khandelwal"));
            Console.ReadKey();

        }
    }
}
