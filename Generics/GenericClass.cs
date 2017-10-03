namespace Generics
{
    class GenericClass<T>
    {
        public static bool AreEqual(T value1, T value2) =>
           value1.Equals(value2);
    }
}
