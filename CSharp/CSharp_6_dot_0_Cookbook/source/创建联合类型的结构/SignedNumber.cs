using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit)]
internal struct SignedNumber
{
    [FieldOffset(0)]
    public sbyte Num1;

    [FieldOffset(0)]
    public short Num2;

    [FieldOffset(0)]
    public int Num3;

    [FieldOffset(0)]
    public long Num4;

    [FieldOffset(0)]
    public float Num5;

    [FieldOffset(0)]
    public double Num6;
}