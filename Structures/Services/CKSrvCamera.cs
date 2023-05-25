using System.Numerics;
using System.Runtime.InteropServices;

namespace AliceStructures.Services
{
    public enum CameraStatus : int
    {
        FocusedPlayers = 0,
        RealTimeAnimation = 1,
        PreRenderedCutscene = 4
    }

    [StructLayout(LayoutKind.Explicit, Pack = 4)]
    public readonly unsafe struct CKSrvCamera
    {
		[FieldOffset(0x4C4)] private readonly float positionX;
		[FieldOffset(0x4C8)] private readonly float positionY;
		[FieldOffset(0x4CC)] private readonly float positionZ;
		[FieldOffset(0x4D0)] private readonly float focusPositionX;
        [FieldOffset(0x4D4)] private readonly float focusPositionY;
        [FieldOffset(0x4D8)] private readonly float focusPositionZ;
        [FieldOffset(0x1774)] private readonly int status;

        public readonly Vector3 FocusedLocation => new(focusPositionX, focusPositionY, focusPositionZ);
		public readonly Vector3 Location => new(positionX, positionY, positionZ);
        public readonly CameraStatus Status => (CameraStatus)status;
    }
}
