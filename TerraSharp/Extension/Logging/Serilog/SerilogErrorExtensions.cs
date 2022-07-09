using Prism.Ioc;
using Serilog;

namespace TerraSharp.Extension.Logging.Serilog
{
    public static class SerilogErrorExtensions
    {
        /// <summary>
        /// Logs Common Exceptions (Dispatched to the Background Thread).
        /// </summary>
        /// <param name="ex">Contains information about the error.</param>
        /// <param name="logger">Serilog Logging Service.</param>
        public static void LogException(this Exception ex)
        {
            Task.Run(() =>
            {
                var logger = ContainerLocator.Container.Resolve<ILogger>();

                string message = string.Empty;
                string stackTrace = string.Empty;
                if (ex.InnerException != null)
                {
                    message = ex.InnerException.Message;
                    stackTrace = ex.InnerException.StackTrace;
                }
                else
                {
                    message = ex.Message;
                    stackTrace = ex.StackTrace;
                }

                logger.Error(ex, String.Concat("Error Message: \n", message, "\n\n", "\nStack Trace:\n", stackTrace));
            });
        }

        public static void LogErrorWithoutException(this ILogger logger, string message)
        {
            Task.Run(() =>
            {
                logger.Error(message);
            });
        }

        public static void LogInformational(this ILogger logger, string message)
        {
            Task.Run(() =>
            {
                logger.Information(message);
            });
        }

        public static void LogWarning(this ILogger logger, string message)
        {
            Task.Run(() => logger.Warning(message));
        }
    }
}
