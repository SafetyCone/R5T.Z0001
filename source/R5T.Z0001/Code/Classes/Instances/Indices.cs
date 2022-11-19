using System;


namespace R5T.Z0001
{
    public class Indices : IIndices
    {
        #region Infrastructure

        public static Indices Instance { get; } = new();

        private Indices()
        {
        }

        #endregion
    }
}
