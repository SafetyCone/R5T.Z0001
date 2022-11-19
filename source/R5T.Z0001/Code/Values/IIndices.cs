using System;

using R5T.T0131;


namespace R5T.Z0001
{
    [ValuesMarker]
    public partial interface IIndices : IValuesMarker
    {
        public static int DefaultFirstIndex => Instances.Integers.Zero;
        public static int NotFoundIndex => Instances.Integers.NegativeOne;
    }
}
