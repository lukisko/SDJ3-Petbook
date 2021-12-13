namespace Entities
{
    public class Comunication<T>
    {
        public string type {get; set;}
        public string method {get; set;}
        public T value {get; set;}
        public Comunication (string type, string method, T value){
            this.type = type;
            this.method = method;
            this.value = value;
        }

        public string toJSON(){
            return "{\"type\":\""+type+"\","+
                "\"method\":\""+method+"\""+
                "}";
        }
    }
}