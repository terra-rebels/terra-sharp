using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace TerraSharp.Core
{
    public class Coins<T> : JsonSerializer, numeric<T>
    {
        public T Value { get => Value; set => Value = value; }

        private Dictionary<string, Coins<T>> _coins { get; set; }
        private string denomination { get; set; }

        public Coins(numeric<T> numerator, string denom)
        {
            _coins = new Dictionary<string, Coins<T>>();
            Value = numerator.Value;
            denomination = denom;
        }

        public string ToCommaSeperatedString()
        {
            return string.Join(",", _coins.Keys);
        }
        public void fromCommaSeperatedString(string coins, numeric<T> numerator)
        {
            //assume the dictionary is not cleared
            _coins.Clear();
            foreach(string s in coins.Split(","))
            {
                _coins.Add(s, new Coins<T>(numerator,""));
            }
        }
        public string getDenomination() => denomination;
        public string[] getDenominations()
        {
            List<string> result = new List<string>();
            foreach(Coins<T> c in _coins.Values)
            {
                result.Add(c.getDenomination());
            }
            return result.ToArray();
        }

    }
}
