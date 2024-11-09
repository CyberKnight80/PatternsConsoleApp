using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsoleApp
{
    public interface Successor
    {
        public void Success(string data);
    }

    public interface FailHandler
    {
        public void Fail(string data);
    }

    public abstract class Step : Successor, FailHandler
    {
        public Step NextStep { get; set; }

        public virtual void Success(string data)
        {
            if(this.NextStep is not null)
            {
                NextStep.Success(data);
            }
        }

        public virtual void Fail(string data)
        {
            if (this.NextStep is not null)
            {
                NextStep.Fail(data);
            }
        }
    }

    public class StepA : Step
    {
        public override void Success(string data)
        {
            try
            {
                Console.WriteLine(":::DOING A:::");
                Console.WriteLine(data);
                base.Success(data);
            }
            catch
            {
                this.Fail(data);
            }
        }

        public override void Fail(string data)
        {
            Console.WriteLine(":::FAILED A:::");
            Console.WriteLine(data);
            base.Success(data);
        }
    }

    public class StepB : Step
    {
        public override void Success(string data)
        {
            try
            {
                Console.WriteLine(":::DOING B:::");
                Console.WriteLine(data);
                base.Success(data);
            }
            catch
            {
                this.Fail(data);
            }
        }

        public override void Fail(string data)
        {
            Console.WriteLine(":::FAILED B:::");
            Console.WriteLine(data);
            base.Success(data);
        }
    }
}
