namespace TerraSharp.Client.Lcd.Api
{
    public abstract class BaseAPI
    {
        protected readonly APIRequester apiRequester;
        public BaseAPI(APIRequester apiRequester)
        {
            this.apiRequester = apiRequester;
        }
    }
}
