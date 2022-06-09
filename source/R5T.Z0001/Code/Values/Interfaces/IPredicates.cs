using System;

using R5T.T0131;


namespace R5T.Z0001
{
    [ValuesMarker]
    public partial interface IPredicates<T> : IValuesMarker
    {
        public Func<T, bool> False => x => false;
        public Func<T, bool> True => x => true;
    }
}
