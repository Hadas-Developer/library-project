using LibraryApplicastion.MiddleWare;

namespace LibraryApplicastion
{
    public static class Extentions
    {
        public static IApplicationBuilder UseShabbatMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ShabbatMiddleware>();
        }
    }
}
