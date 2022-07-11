

using Xamarin.Essentials;

namespace TerraSharp.Extension.Platform
{
    public class TerraPlatformHelper
    {
        /// <summary>
        /// Whether the device is running the iOS Platform.
        /// </summary>
        /// <returns>Is the device an iOS device.</returns>
        public static bool IsiOS() => DeviceInfo.Platform == DevicePlatform.iOS;

        /// <summary>
        /// Whether the device is running the Android Platform.
        /// </summary>
        /// <returns>Is the device an Android device.</returns>
        public static bool IsAndroid() => DeviceInfo.Platform == DevicePlatform.Android;

        /// <summary>
        /// Whether the device is running the UWP Platform.
        /// </summary>
        /// <returns>Is the device an UWP device.</returns>
        public static bool IsUWP() => DeviceInfo.Platform == DevicePlatform.UWP;
    }
}
