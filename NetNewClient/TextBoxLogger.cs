using System;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;

namespace NetNewClient
{
    public class TextBoxLogger : ILogger
    {
        private readonly TextBox _textBox;
        private readonly string _categoryName;

        public TextBoxLogger(TextBox textBox, string categoryName = "App")
        {
            _textBox = textBox;
            _categoryName = categoryName;
        }

        public IDisposable BeginScope<TState>(TState state) => null;

        public bool IsEnabled(LogLevel logLevel) => true;

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (formatter == null) return;
            string message = $"[{DateTime.Now:HH:mm:ss}] [{logLevel}] {_categoryName}: {formatter(state, exception)}";
            if (exception != null)
                message += $" Exception: {exception}";
            if (_textBox.InvokeRequired)
            {
                _textBox.Invoke(new Action(() => _textBox.AppendText(message + Environment.NewLine)));
            }
            else
            {
                _textBox.AppendText(message + Environment.NewLine);
            }
        }
    }
}
