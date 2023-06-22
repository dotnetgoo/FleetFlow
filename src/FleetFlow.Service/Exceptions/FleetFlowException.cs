namespace FleetFlow.Service.Exceptions
{
    public class FleetFlowException : Exception
    {
        public int Code { get; set; }
        public FleetFlowException(int code = 500, string message = "Something went wrong") : base(message)
        {
            this.Code = code;
        }
    }
}