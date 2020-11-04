namespace Carvajal.API.Utilities
{
    public class ApiResponse<T>
    {

        public T Data { get; set; }

        public int StatusCode { get; set; }

        public ApiResponse(T data)
        {
            Data = data;
        }

    }
}
