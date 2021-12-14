namespace Edudocs.Common.Options
{
    /// <summary>
    /// Available degrees
    /// </summary>
    [Flags]
    public enum DegreeOptions
    {
        None = 0,
        Bachelor = 1,
        Master = 2,
        Postgraduate = 4,
        All = 8,
    }
}
