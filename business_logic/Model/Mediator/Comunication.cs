namespace business_logic.Model.Mediator
{
    public class Comunication<T>
    {
        private string type {get;}
        private string method {get;}
        private T value {get;}
        public Comunication (string type, string method, T value){
            this.type = type;
            this.method = method;
            this.value = value;
        }
    }
}