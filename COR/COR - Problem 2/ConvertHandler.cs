using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR2
{

    public class Value
    {
        public double Val { get; set; }
        public String Type { get; set; }

        public Value(double va, String ty)
        {
            Val = va;
            Type = ty;
        }
    }

    public interface IConversion
    {
        String getValue();
    }

    public class BaseValue : IConversion
    {
        protected Value val;

        public BaseValue(Value va)
        {
            val = va;
        }

        public String getValue()
        {
            return val.Val.ToString();
        }
    }

    public abstract class ValueDecorator : IConversion
    {
        protected IConversion decoratedConversion;

        public ValueDecorator(IConversion c)
        {
            this.decoratedConversion = c;
        }

        public virtual String getValue()
        {
            return decoratedConversion.getValue();
        }

    }

    public class RoundDecorator : ValueDecorator
    {
        public RoundDecorator(IConversion c)
            : base(c)
        {

        }

        public override String getValue()
        {
            return Math.Round(System.Convert.ToDouble(base.getValue()), 2).ToString();
        }

    }

    public class ExpDecorator : ValueDecorator
    {
        public ExpDecorator(IConversion c)
            : base(c)
        {

        }

        public override String getValue()
        {
            return System.Convert.ToDouble(base.getValue()).ToString("e2");
        }

    }

    public class TypeDecorator : ValueDecorator
    {
        String type;

        public TypeDecorator(String typ, IConversion c)
            : base(c)
        {
            type = typ;
        }

        public override String getValue()
        {
            return base.getValue() + " " + type + "s" ;
        }

    }
    
    public abstract class ConvertHandler
    {
        
        protected String handleType;
        protected ConvertHandler next;

        public ConvertHandler(String str){
            this.handleType = str;
        }

        public ConvertHandler SetNext(ConvertHandler nextHandler)
        {
            next = nextHandler;
            return nextHandler;
        }

        public Value Handle(String target, int inputNum)
        {

            if (handleType.Equals(target))
            {
                // return here means we stop the chain push value up the chain
                return Convert(inputNum);
            }

            if (next != null)
            {
                //didn't hit so go down the chain and see if another handler hits
               return next.Handle(target, inputNum);
            }
            else
            {
                // none hit so null or error
                return null;
            }
        }

        abstract protected Value Convert(int inputNum);
    }

    public class MILE_Handler : ConvertHandler
    {
        public MILE_Handler(String type) : base(type) { }

        protected override Value Convert(int inputNum)
        {
            return new Value(inputNum * 0.621371, "Mile");
        }
    }
    public class YARD_Handler : ConvertHandler
    {
        public YARD_Handler(String type) : base(type) { }

        protected override Value Convert(int inputNum)
        {
            return new Value(inputNum * 1093.61, "Yard");
        }
    
    }
    public class FOOT_Handler : ConvertHandler
    { 
        public FOOT_Handler(String type) : base(type) { }

        protected override Value Convert(int inputNum)
        {
            return new Value(inputNum * 3280.84, "Foot");
        }
    
    }
}
