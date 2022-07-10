using Xamarin.Forms;

namespace TerraSharp.Extension.Platform
{
    public class TerraPlatformHelper
    {
        /// <summary>
        /// Whether the device is running the iOS Platform.
        /// </summary>
        /// <returns>Is the device an iOS device.</returns>
        public static bool IsiOS() => Device.RuntimePlatform == Device.iOS;

        /// <summary>
        /// Whether the device is running the Android Platform.
        /// </summary>
        /// <returns>Is the device an Android device.</returns>
        public static bool IsAndroid() => Device.RuntimePlatform == Device.Android;

        /// <summary>
        /// Whether the device is running the UWP Platform.
        /// </summary>
        /// <returns>Is the device an UWP device.</returns>
        public static bool IsUWP() => Device.RuntimePlatform == Device.UWP;

        /// <summary>
        /// Whether the device is in Dark Mode.
        /// </summary>
        /// <returns>Dark Mode.</returns>
        public static bool IsDarkMode() => Application.Current.RequestedTheme == OSAppTheme.Dark;

        /// <summary>
        /// Whether the device is in Light Mode.
        /// </summary>
        /// <returns>Dark Mode.</returns>
        public static bool IsLightMode() => Application.Current.RequestedTheme == OSAppTheme.Dark;

        /// <summary>
        /// Whether the device is in Default Mode.
        /// </summary>
        /// <returns>Dark Mode.</returns>
        public static bool IsColourModeUnknown() => Application.Current.RequestedTheme == OSAppTheme.Unspecified;
    }
}
