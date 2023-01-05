namespace PizzariaCSharp.Exceptions
{
    public class DataNotFoundException : Exception
    {
        public DataNotFoundException() : base("Dados não encontrados.") {}
        public DataNotFoundException(string message) : base(message) {}
        public DataNotFoundException(string message, System.Exception inner) : base(message, inner) {}
        public DataNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) {}   }
}