using System;

namespace business_logic.Model
{
    public class Option<T>
    {
        bool ok;
        T obj;
        public Option(){
            ok = false;
        }

        public Option(T obj){
            if (obj == null) throw new ArgumentNullException("object can not be null");
            ok = true;
            this.obj = obj;
        }
        public bool isOK(){
            return this.ok;
        }

        public T getOption(){
            if (ok){
                return obj;
            } else {
                throw new FieldAccessException("you can not access nothing");
            }
        }

    }
}