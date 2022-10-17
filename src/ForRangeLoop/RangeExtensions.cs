using ForRangeLoop;

/// <summary>Defined globally to be used without adding any using</summary>
public static class RangeExtensions
{
    public static RangeEnumerator GetEnumerator(this in Range range)
    {
        if (range.Start.IsFromEnd || range.End.IsFromEnd)
        {
            throw new NotSupportedException("Index from end is not supported");
        }
        return new(range.Start.Value, range.End.Value);
    }
}