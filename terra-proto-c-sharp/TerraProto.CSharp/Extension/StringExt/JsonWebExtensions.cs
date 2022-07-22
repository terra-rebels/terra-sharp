using System.Text;

namespace TerraProto.CSharp.Extension.StringExt
{
    public static class JsonWebExtensions
    {
        public static object PrepareSignBytes(object obj)
        {
            //if (obj is Array)
            //{
            //    (obj as Array).ToList()
            //}



            return null;
        }



        public static object RemoveNull(object obj)
        {
            if (obj != null && obj is string) // Check if object is json
            {

            }

            return obj;
        }
        public static string FormatJson(this string json)
        {
            if (!string.IsNullOrWhiteSpace(json))
            {
                StringBuilder jsonFormatter = new StringBuilder();
                jsonFormatter.Append(json);
                jsonFormatter.Replace("\\", string.Empty);
                return jsonFormatter.ToString().Trim('"');
            }
            else
                return json;
        }

    }
}
