namespace ECommerce.API
{
    public class GenericResponse<T> where T : class
    {
        public MessageResponse Message { get; set; }
        public T Result { get; set; }
    }
    public class MessageResponse
    {
        public int Code { get; set; }
        public string Message { get; set; }
    }
}
