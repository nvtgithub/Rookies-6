using System.Diagnostics;

namespace AssignmentDay1.Middlewares
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IWebHostEnvironment _hostEnvironment;

        public LoggingMiddleware(RequestDelegate next, IWebHostEnvironment hostEnvironment)
        {
            _next = next;
            _hostEnvironment = hostEnvironment;
        }

        public async Task Invoke(HttpContext context)
        {
            var request = context.Request;

            string requestInfo = "Scheme " + request.Scheme +
            "\nHost " + request.Host +
            "\nPath " + request.Path +
            "\nQueryString " + request.QueryString +
            "\nRequestBody " + request.Body;

            Debug.Write(requestInfo);
            File.WriteAllText("Information.txt", requestInfo);

            //Write to file by Stream
            // var directoryPath = Path.Combine(_hostEnvironment.WebRootPath, "LogText");
            // MiddlewareExtentions.WriteToFileByStream(directoryPath, "RequestLog.txt", requestInfo.ToString());

            await _next(context);
        }
    }
}