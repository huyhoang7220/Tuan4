

namespace LambdaExpression
{
    internal static class Extenssion
    {
        public static IEnumerable<T> WhereCustom<T>(this IEnumerable<T> list, Func<T, bool> predicate)
        {
            List < T > t = new List<T>() ;
            foreach (var item in list)
            {
                if (predicate(item))
                {
                    t.Add(item) ;
                }
            }
            return t;   
        }
    }
}
