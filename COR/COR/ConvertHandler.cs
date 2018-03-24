using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR1
{
    
    
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

        public double Handle(String target, int inputNum)
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
                // none hit so 0.0 or error
                return 0.0;
            }
        }

        abstract protected double Convert(int inputNum);
    }

    public class MILE_Handler : ConvertHandler
    {
        public MILE_Handler(String type) : base(type) { }

        protected override double Convert(int inputNum)
        {
            return inputNum * 0.621371;
        }
    }
    public class YARD_Handler : ConvertHandler
    {
        public YARD_Handler(String type) : base(type) { }

        protected override double Convert(int inputNum)
        {
            return inputNum * 1093.61;
        }
    
    }
    public class FOOT_Handler : ConvertHandler
    { 
        public FOOT_Handler(String type) : base(type) { }

        protected override double Convert(int inputNum)
        {
            return inputNum * 3280.84;
        }
    
    }
}
