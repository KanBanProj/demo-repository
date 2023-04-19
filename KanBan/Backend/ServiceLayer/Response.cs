
    public class Response
    {
        public readonly string ErrorMessage;
        public bool ErrorOccured { get => ErrorMessage != null; }
        internal Response() { }
        internal Response(string msg)
        {
            this.ErrorMessage = msg;
        }
    }
