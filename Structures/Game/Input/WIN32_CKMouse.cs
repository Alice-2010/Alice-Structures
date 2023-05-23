using System.Runtime.InteropServices;

namespace AliceStructures.Game.Input
{
    [StructLayout(LayoutKind.Explicit, Pack = 4, Size = 0x84)]
    public readonly unsafe struct WIN32_CKMouse
    {
        [FieldOffset(0x5C)] private readonly float x;
        [FieldOffset(0x60)] private readonly float y;

        public readonly float X => x;
        public readonly float Y => y;
    }
}
