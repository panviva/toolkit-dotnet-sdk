namespace Panviva.Sdk.Services.Core.Extensions
{
    public static class StringExtensions
    {
        public static string AddSegmentToUrl(this string url, string segmentValue)
        {
            return url + '/' + segmentValue;
        }

        public static string AddParameterToUrl(this string url, string parameterName, string parameterValue)
        {
            return url + '?' + parameterName + '=' + parameterValue;
        }
    }
}
