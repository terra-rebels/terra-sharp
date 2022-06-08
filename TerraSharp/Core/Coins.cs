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

        private Dictionary<string, Coins<T>>? _coins { get; set; }
        private string denomination { get; set; }
        private string name { get; set; }

        public Coins(string n, numeric<T> numerator, string denom, params T[] args) : base()
        {
            if(args.GetType() == typeof(Coins<T>))
            {
                _coins = new Dictionary<string, Coins<T>>();
                foreach (Coins<T> c in (Coins<T>[])(object)args)
                    _coins.Add(c.getName(), c);
            }
            else if(args.GetType() == typeof(string))
            {
                _coins = new Dictionary<string, Coins<T>>();
                foreach (string s in (List<string>)(object)args)
                    fromCommaSeperatedString(s, numerator);
            }
            else
            {
                _coins = null;
                Value = numerator.Value;
                denomination = denom;
            }
            Value = numerator.Value;
            denomination = denom;
            name  = n;
        }

        public string getName() => name;

        public string ToCommaSeperatedString()
        {
            return string.Join(",", _coins.Keys);
        }
        public void fromCommaSeperatedString(string coins, numeric<T> numerator)
        {
            foreach(string s in coins.Split(","))
            {
                _coins.Add(s, new Coins<T>(s,numerator, ""));
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
        public Coins<T>? getByName(string name) => _coins.FirstOrDefault(x => x.Key == name).Value ?? default;
        public Coins<T>[]? getByDenomination(string denom)
        {
            List<Coins<T>> _c = new List<Coins<T>>();

            if(_coins != null)
            {
                foreach (Coins<T> c in _coins.Values)
                {
                    if (c.getDenomination() == denom)
                        _c.Add(c);
                }
            }

            return _c.ToArray();
        }
    }
}
