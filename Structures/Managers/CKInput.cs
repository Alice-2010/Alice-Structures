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

    [StructLayout(LayoutKind.Explicit, Pack = 4, Size = 0x8C)]
    public readonly unsafe struct CKInput
    {
        [FieldOffset(0x4)] private readonly WIN32_CKPad* gamepad1;
        [FieldOffset(0x8)] private readonly WIN32_CKMouse* mouse;
        [FieldOffset(0xC)] private readonly WIN32_CKKeyboard* keyboard;
        [FieldOffset(0x1C)] private readonly InputSlot player1;
        [FieldOffset(0x20)] private readonly InputSlot player2;
        [FieldOffset(0x2C)] private readonly CKAction* action;
        [FieldOffset(0x38)] private readonly CKFilterBinary* binaryFilter;
        [FieldOffset(0x40)] private readonly CKFilterAnalog* analogFilter;
        [FieldOffset(0x44)] private readonly CKMapping* mapping;
        [FieldOffset(0x48)] private readonly CKComboManager* comboManager;
        [FieldOffset(0x64)] private readonly CKCombo* combo;
        [FieldOffset(0x68)] private readonly CKComboTransition* comboTransition;

        public readonly WIN32_CKPad* Gamepad1 => gamepad1;
        public readonly WIN32_CKMouse* Mouse => mouse;
        public readonly WIN32_CKKeyboard* Keyboard => keyboard;
        public readonly InputSlot Player1 => player1;
        public readonly InputSlot Player2 => player2;

        public readonly bool AreControlsBeingAssigned => player1 == InputSlot.Assigning && player2 == InputSlot.Disabled;
    }
}
