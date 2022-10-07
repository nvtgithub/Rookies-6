namespace AssignmentDay1.Middlewares
{
    public static class MiddlewareExtentions
    {
        public static IApplicationBuilder UseLoggingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggingMiddleware>();
        }

        public static void WriteToFileByStream(string directoryPath, string fileName, string textContent)
        {
            using (var fileStream = new FileStream(Path.Combine(directoryPath, fileName), FileMode.OpenOrCreate))
            {
                using (var writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(textContent);
                }
            }
        }
    }
}