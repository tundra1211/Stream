using Stream.API.Domain.Models;

namespace Stream.API.Domain.Services.Communication
{
    public class SaveResultResponse : BaseResponse
    {
        public Result Result { get; private set; }

        private SaveResultResponse(bool success, string message, Result result) : base(success, message)
        {
            Result=result;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="category">Saved category.</param>
        /// <returns>Response.</returns>
        public SaveResultResponse(Result result) : this(true, string.Empty, result)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public SaveResultResponse(string message) : this(false, message, null)
        { }
    }
}