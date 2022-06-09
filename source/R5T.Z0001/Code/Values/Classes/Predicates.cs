using System;


namespace R5T.Z0001
{
    public class Predicates<T> : IPredicates<T>
    {
        #region Infrastructure

        public static Predicates<T> Instance { get; } = new();

        private Predicates()
        {
        }

        #endregion
    }
}
