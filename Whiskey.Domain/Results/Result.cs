using Whiskey.Domain.Notifications;
using Whiskey.Domain.Results.Interfaces;

namespace Whiskey.Domain.Results
{
    public class Result : IResult
    {
        private List<Notification> _notifications;

        public Result(int statusCode, string message, object data)
        {
            StatusCode = statusCode;
            Message = message;
            Data = data;
            _notifications = new List<Notification>();
        }

        public int StatusCode { get; private set; }
        public string Message { get; private set; }
        public object Data { get; private set; }

        public IReadOnlyCollection<Notification> Notifications => _notifications;

        public void AddNotification(List<Notification> notifications)
        {
            _notifications = notifications;
        }

        public void SetData(object data)
        {
            Data = data;
        }
    }
}
