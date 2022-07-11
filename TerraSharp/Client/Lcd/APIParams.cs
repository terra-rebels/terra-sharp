using static TerraSharp.Globals.Exceptions;

namespace TerraSharp.Client.Lcd
{
    public class APIParams<T>
    {
        private Dictionary<string, T?> _params { get; set; }

        public APIParams(string key, T? type)
        {
            if (type == null || type.GetType() == typeof(string) || type.GetType() == typeof(double))
            {
                _params = new Dictionary<string, T?>();
                _params.Add(key, type);
            }
            else throw APIParamsTypeInvalidException;
        }

        public Dictionary<string, T?> getParams() => _params;
        public void addParams(string key, T? type) => _params.Add(key, type);
        public T? getParamsByKey(string key) => _params[key];
    }
}
