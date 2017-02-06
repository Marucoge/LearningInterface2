using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Diagnostics.Debug;

namespace LearningInterface2
{
    class Program
    {
        static void Main(string[] args)
        {
            ImplementorA implementorA = new ImplementorA();
            ImplementorB implementorB = new ImplementorB();

            // 同じインターフェイスを実装した、別々のクラスをメソッドに渡す。
            CallViaInterface(implementorA);
            CallViaInterface(implementorB);
        }

        public interface ISharedTask
        {
              void SharedTask();
        }

        public class ImplementorA : ISharedTask
        {
            public void SharedTask()     {    WriteLine("ImplementorA");   }
        }

        public class ImplementorB : ISharedTask
        {
            public void SharedTask()    {  WriteLine("ImplementorB");  }
        }

        // インターフェイスへの参照を引数として取る。
        // 指定されたインターフェイスを実装したクラスのインスタンス(への参照)からは、
        // インターフェイスへの参照を取り出すことができるとか。
        public static void CallViaInterface( ISharedTask implementor)
        {
            implementor.SharedTask();
        }
    }
}
