using AliceStructures.Game.Input;
using System.Runtime.InteropServices;

namespace AliceStructures.Managers
{
    public enum InputSlot : int
    {
        Disabled = 0,
        Keyboard = 1,
        Controller1 = 2,
        Controller2 = 3, // assuming this is the case - my 2nd controller wont work alongside the first
        Assigning = 4,
    }

    [StructLayout(LayoutKind.Explicit, Pack = 4)]
    public readonly unsafe struct CKInput
    {
        [FieldOffset(0x4)] private readonly WIN32_CKPad* gamepad1;
        [FieldOffset(0x8)] private readonly WIN32_CKMouse* mouse;
        [FieldOffset(0xC)] private readonly WIN32_CKKeyboard* keyboard;
        [FieldOffset(0x1C)] private readonly InputSlot player1;
        [FieldOffset(0x20)] private readonly InputSlot player2;

        public readonly InputSlot Player1 => player1;
        public readonly InputSlot Player2 => player2;

        public readonly bool AreControlsBeingAssigned => player1 == InputSlot.Assigning && player2 == InputSlot.Disabled;
    }
}
