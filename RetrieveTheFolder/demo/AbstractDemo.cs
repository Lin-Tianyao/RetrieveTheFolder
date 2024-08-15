using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RetrieveTheFolder.demo
{
    public interface IDemo
    {
        void TestServcie();
    }
    public abstract class AbstractDemo:IDemo
    {
        public abstract void Test();

        public virtual void Hello() {
            Console.WriteLine("this is AbstractDemo...");
        }
    }

    public abstract class AbstractChildDemo : AbstractDemo
    {
        public abstract void TestChild();
        public override void Hello() => Console.WriteLine("this is AbstractChildDemo...");
    }

    public class Demo : AbstractChildDemo
    {
        public override void Test()
        {
            throw new NotImplementedException();
        }

        public override void TestChild()
        {
            throw new NotImplementedException();
        }
    }
}
