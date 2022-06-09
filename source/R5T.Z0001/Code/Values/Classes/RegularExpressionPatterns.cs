using System;


namespace R5T.Z0001
{
    public class RegularExpressionPatterns : IRegularExpressionPatterns
    {
        #region Infrastructure

        public static RegularExpressionPatterns Instance { get; } = new();

        private RegularExpressionPatterns()
        {
        }

        #endregion
    }
}
