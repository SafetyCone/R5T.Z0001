using System;

using R5T.T0131;


namespace R5T.Z0001
{
    /// <summary>
    /// Contains patterns for the .NET C# <see cref="System.Text.RegularExpressions.Regex"/>.
    /// </summary>
    /// <remarks>
    /// Some good sources:
    /// * https://www.mikesdotnetting.com/article/46/c-regular-expressions-cheat-sheet
    /// </remarks>
    [ValuesMarker]
    public partial interface IRegularExpressionPatterns : IValuesMarker
    {
        /// <summary>
        /// Any non-word character.
        /// <para><value>\W</value></para>
        /// </summary>
        // language=regex
        public string AllNonAlphanumeric => @"\W";
    }
}
