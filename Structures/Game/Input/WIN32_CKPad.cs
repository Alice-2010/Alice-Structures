using System.Runtime.InteropServices;

namespace AliceStructures.Game.Input
{
    [StructLayout(LayoutKind.Explicit, Pack = 4, Size = 0x6C)]
    public readonly unsafe struct WIN32_CKPad
    {
        [FieldOffset(0x3A)] private readonly byte leftStickUp;
        [FieldOffset(0x3B)] private readonly byte leftStickDown;
        [FieldOffset(0x3C)] private readonly byte leftStickLeft;
        [FieldOffset(0x3D)] private readonly byte leftStickRight;

        [FieldOffset(0x3E)] private readonly byte rightStickUp;
        [FieldOffset(0x3F)] private readonly byte rightStickDown;
        [FieldOffset(0x40)] private readonly byte rightStickLeft;
        [FieldOffset(0x41)] private readonly byte rightStickRight;

        [FieldOffset(0x42)] private readonly byte a;
        [FieldOffset(0x43)] private readonly byte x;
        [FieldOffset(0x44)] private readonly byte b;
        [FieldOffset(0x45)] private readonly byte y;

        [FieldOffset(0x46)] private readonly byte leftBumper;
        [FieldOffset(0x47)] private readonly byte leftTrigger;
        [FieldOffset(0x48)] private readonly byte rightBumper;
        [FieldOffset(0x49)] private readonly byte rightTrigger;

        [FieldOffset(0x4A)] private readonly byte select;
        [FieldOffset(0x4B)] private readonly byte start;
        [FieldOffset(0x4C)] private readonly byte leftStick;
        [FieldOffset(0x4D)] private readonly byte rightStick;

        [FieldOffset(0x4E)] private readonly byte dpadUp;
        [FieldOffset(0x4F)] private readonly byte dpadDown;
        [FieldOffset(0x50)] private readonly byte dpadLeft;
        [FieldOffset(0x51)] private readonly byte dpadRight;

        public readonly byte LeftStickUp => leftStickUp;
        public readonly byte LeftStickDown => leftStickDown;
        public readonly byte LeftStickLeft => leftStickLeft;
        public readonly byte LeftStickRight => leftStickRight;
        public readonly byte RightStickUp => rightStickUp;
        public readonly byte RightStickDown => rightStickDown;
        public readonly byte RightStickLeft => rightStickLeft;
        public readonly byte RightStickRight => rightStickRight;
        public readonly bool A => a == 255;
        public readonly bool X => x == 255;
        public readonly bool B => b == 255;
        public readonly bool Y => y == 255;
        public readonly bool LeftBumper => leftBumper == 255;
        public readonly byte LeftTrigger => leftTrigger;
        public readonly bool RightBumper => rightBumper == 255;
        public readonly byte RightTrigger => rightTrigger;
        public readonly bool Select => select == 255;
        public readonly bool Start => start == 255;
        public readonly bool LeftStick => leftStick == 255;
        public readonly bool RightStick => rightStick == 255;
        public readonly bool DPadUp => dpadUp == 255;
        public readonly bool DPadDown => dpadDown == 255;
        public readonly bool DPadLeft => dpadLeft == 255;
        public readonly bool DPadRight => dpadRight == 255;
    }
}
