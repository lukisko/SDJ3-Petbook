namespace business_logic.Model.Mediator
{
    public class Comunication<T>
    {
        public string type {get;}
        public string method {get;}
        public T value {get;}
        public Comunication (string type, string method, T value){
            this.type = type;
            this.method = method;
            this.value = value;
        }
    }
}