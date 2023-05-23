using System.Runtime.InteropServices;

namespace AliceStructures.Graphics
{
    [StructLayout(LayoutKind.Explicit, Size = 0x1A0, Pack = 4)]
    public readonly unsafe struct WIN32_CKVideo
    {
        [FieldOffset(0xC)] private readonly string filePath;

        public readonly string FilePath => filePath;
    }
}
