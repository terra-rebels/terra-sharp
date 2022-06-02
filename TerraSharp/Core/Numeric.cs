using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TerraSharp.Globals.Exceptions;

namespace TerraSharp.Core
{
    public interface numeric<T>
    {
        public T Value { get; set; }

        public void add(T value)
        {
            if (value.GetType() == Value.GetType())
            {
                dynamic a = value;
                dynamic b = Value;
                Value = a+b;
            }
            else throw TypeInconcistencyException;

        }
        public void sub(T value)
        {
            if (value.GetType() == Value.GetType())
            {
                dynamic a = value;
                dynamic b = Value;
                Value = a-b;
            }
            else throw TypeInconcistencyException;

        }

        public void mul(T value)
        {
            if (value.GetType() == Value.GetType())
            {
                dynamic a = value;
                dynamic b = Value;
                Value = a*b;
            }
            else throw TypeInconcistencyException;

        }

        public void div(T value)
        {
            if (value.GetType() == Value.GetType())
            {
                dynamic a = value;
                dynamic b = Value;
                Value = a/b;
            }
            else throw TypeInconcistencyException;

        }

        public void mod(T value)
        {
            if (value.GetType() == Value.GetType())
            {
                dynamic a = value;
                dynamic b = Value;
                Value = a%b;
            }
            else throw TypeInconcistencyException;

        }
    }
    
    public class Numeric
    {
        private static readonly int DEC_PERCISION = 18;
        
        class tNumber<T> : numeric<T>
        {
            public T Value { get => Value; set => Value = value; }

            public string toString()
            {
                if (typeof(T) == typeof(double))
                {
                    string str = Value.ToString();
                    return string.Format(str, "N"+DEC_PERCISION);
                }
                else if (typeof(T) == typeof(int))
                {
                    string str = Value.ToString();
                    return string.Format(str, "N"+0);
                }
                else
                {
                    throw TypeInconcistencyException;
                }
            }

            public tNumber<int> toTInteger()
            {
                return new tNumber<int> { Value = (dynamic)this.Value };
            }

            public tNumber<double> toTDouble()
            {
                return new tNumber<double> { Value = (dynamic)this.Value };
            }
        }
    }
}
