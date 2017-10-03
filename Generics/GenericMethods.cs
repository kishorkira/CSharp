namespace Generics
{
    class GenericMethods
    {
        public static bool AreEqual<T>(T value1,T value2)=>
           value1.Equals(value2);
        
    }
}
