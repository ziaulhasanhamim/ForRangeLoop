namespace ForRangeLoop;

public struct RangeEnumerator
{
    public RangeEnumerator(int start, int end)
    {
        Start = start;
        End = end;
        Current = start;
    }

    public int Start { get; }
    public int End { get; }

    public int Current { get; private set; }

    public bool MoveNext()
    {
        Current++;
        return Current < End;
    }
}