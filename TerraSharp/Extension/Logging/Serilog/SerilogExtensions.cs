using System.Reflection;
using System.Text;

namespace TerraSharp.Extension.Logging.Serilog
{
    public class SerilogExtensions
    {
        public static string FormatExceptionSimple(Exception ex)
        {
            if (ex == null)
                return String.Empty;
            var sb = new StringBuilder();
            try
            {
                sb.AppendFormat("\r\n-----------\r\n{0}", ex.ToString());
            }
            catch (Exception ex0)
            {
                sb.AppendFormat("Warning; Could not format exception {0}", ex0.ToString());
            }
            return sb.ToString();
        }

        /// <summary>
        /// By default return Exception.ToString()
        /// </summary>
        private static readonly Func<Exception, string> defaultFormatter =
            (ex) => (ex == null) ? String.Empty : ex.ToString();

        public static string FormatException(Exception ex, bool includeContext = false)
        {
            if (ex == null)
                return String.Empty;
            var sb = new StringBuilder();
            try
            {
                // Whether or not to include the application and machine context
                if (includeContext)
                    AppendContext(sb);

                AppendExceptionInfo(sb, ex, 0);
            }
            catch (Exception ex0)
            {
                sb.AppendFormat("Warning; Could not format exception {0}", ex0.ToString());
            }

            return sb.ToString();
        }

        private static void AppendExceptionInfo(StringBuilder sb,
            Exception exception, int depth)
        {
            Func<Exception, string> formatter = defaultFormatter;

            sb.AppendFormat("\r\n------------------------------\r\n{0}",
                formatter(exception));
        }

        private static void AppendContext(StringBuilder sb)
        {
            var currentAssembly = Assembly.GetEntryAssembly() ?? Assembly.GetCallingAssembly();
            var lastWritten = File.GetLastWriteTime(currentAssembly.Location);

            sb.AppendFormat("[Context] assembly={0},version={1},buildTime={2},appDomain={3},basePath={4}",
                currentAssembly.FullName,
                currentAssembly.GetName().Version.ToString(),
                lastWritten,
                AppDomain.CurrentDomain.FriendlyName,
                AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
