namespace DataModificationLibrary.Abstraction
{
    //Generic class, where generic`s type is a type, which this class can transform
    public abstract class Plugin<T>
    {
        //Property to save the data
        protected T Data { get; set; }

        //Method with parameter of plugin`s generic type and return modified value of the same type
        public virtual T Modify(T data)
        {
            return data;
        }
    }
}
