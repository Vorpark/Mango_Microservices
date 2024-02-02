namespace Mango.Web.Utility
{
    public static class SD
    {
        public static string CouponAPIBase { get; set; }
        public static string AuthAPIBase { get; set; }
        public enum ApiType
        {
            GET,
            POST, 
            PUT,
            DELETE
        }
    }
}
