﻿using System.Runtime.InteropServices;

namespace AliceStructures.Game.Input
{
    [StructLayout(LayoutKind.Explicit, Pack = 4, Size = 0x1B8)]
    public readonly unsafe struct WIN32_CKKeyboard
    {
        [FieldOffset(0x5)] private readonly byte escape;
        [FieldOffset(0x6)] private readonly byte one;
        [FieldOffset(0x7)] private readonly byte two;
        [FieldOffset(0x8)] private readonly byte three;
        [FieldOffset(0x9)] private readonly byte four;
        [FieldOffset(0xA)] private readonly byte five;
        [FieldOffset(0xB)] private readonly byte six;
        [FieldOffset(0xC)] private readonly byte seven;
        [FieldOffset(0xD)] private readonly byte eight;
        [FieldOffset(0xE)] private readonly byte nine;
        [FieldOffset(0xF)] private readonly byte zero;

        [FieldOffset(0x10)] private readonly byte dash;
        [FieldOffset(0x12)] private readonly byte backspace;
        [FieldOffset(0x13)] private readonly byte tab;
        [FieldOffset(0x14)] private readonly byte q;
        [FieldOffset(0x15)] private readonly byte w;
        [FieldOffset(0x16)] private readonly byte e;
        [FieldOffset(0x17)] private readonly byte r;
        [FieldOffset(0x18)] private readonly byte t;
        [FieldOffset(0x19)] private readonly byte y;
        [FieldOffset(0x1A)] private readonly byte u;
        [FieldOffset(0x1B)] private readonly byte i;
        [FieldOffset(0x1C)] private readonly byte o;
        [FieldOffset(0x1D)] private readonly byte p;
        [FieldOffset(0x1F)] private readonly byte equals;

        [FieldOffset(0x20)] private readonly byte enter;
        [FieldOffset(0x21)] private readonly byte leftControl;
        [FieldOffset(0x22)] private readonly byte a;
        [FieldOffset(0x23)] private readonly byte s;
        [FieldOffset(0x24)] private readonly byte d;
        [FieldOffset(0x25)] private readonly byte f;
        [FieldOffset(0x26)] private readonly byte g;
        [FieldOffset(0x27)] private readonly byte h;
        [FieldOffset(0x28)] private readonly byte j;
        [FieldOffset(0x29)] private readonly byte k;
        [FieldOffset(0x2A)] private readonly byte l;
        [FieldOffset(0x2B)] private readonly byte semicolon;
        [FieldOffset(0x2C)] private readonly byte hashtag;
        [FieldOffset(0x2D)] private readonly byte apostrophe;
        [FieldOffset(0x2E)] private readonly byte leftShift;

        [FieldOffset(0x30)] private readonly byte z;
        [FieldOffset(0x31)] private readonly byte x;
        [FieldOffset(0x32)] private readonly byte c;
        [FieldOffset(0x33)] private readonly byte v;
        [FieldOffset(0x34)] private readonly byte b;
        [FieldOffset(0x35)] private readonly byte n;
        [FieldOffset(0x36)] private readonly byte m;
        [FieldOffset(0x37)] private readonly byte comma;
        [FieldOffset(0x38)] private readonly byte fullstop;
        [FieldOffset(0x39)] private readonly byte forwardslash;
        [FieldOffset(0x3A)] private readonly byte rightshift;
        [FieldOffset(0x3B)] private readonly byte numpadAsterisk;
        [FieldOffset(0x3C)] private readonly byte alt;
        [FieldOffset(0x3D)] private readonly byte space;
        [FieldOffset(0x3E)] private readonly byte capsLock;

        [FieldOffset(0x49)] private readonly byte numLock;
        [FieldOffset(0x4A)] private readonly byte scrollLock;
        [FieldOffset(0x4B)] private readonly byte numpadSeven;
        [FieldOffset(0x4C)] private readonly byte numpadEight;
        [FieldOffset(0x4D)] private readonly byte numpadNine;
        [FieldOffset(0x4E)] private readonly byte numpadDash;
        [FieldOffset(0x4F)] private readonly byte numpadFour;

        [FieldOffset(0x50)] private readonly byte numpadFive;
        [FieldOffset(0x51)] private readonly byte numpadSix;
        [FieldOffset(0x52)] private readonly byte numpadPlus;
        [FieldOffset(0x53)] private readonly byte numpadOne;
        [FieldOffset(0x54)] private readonly byte numpadTwo;
        [FieldOffset(0x55)] private readonly byte numpadThree;
        [FieldOffset(0x56)] private readonly byte numpadZero;
        [FieldOffset(0x57)] private readonly byte numpadFullstop;
        [FieldOffset(0x5F)] private readonly byte backtick;

        [FieldOffset(0x60)] private readonly byte squareBracketRight;
        [FieldOffset(0x61)] private readonly byte backslash;
        [FieldOffset(0x62)] private readonly byte squareBracketLeft;
        [FieldOffset(0x6E)] private readonly byte numpadEnter;
        [FieldOffset(0x6F)] private readonly byte rightcontrol;

        [FieldOffset(0x78)] private readonly byte numpadForwardslash;
        [FieldOffset(0x7A)] private readonly byte altgr;
        [FieldOffset(0x7B)] private readonly byte pauseBreak;
        [FieldOffset(0x7C)] private readonly byte home;
        [FieldOffset(0x7D)] private readonly byte arrowup;
        [FieldOffset(0x7E)] private readonly byte pageUp;
        [FieldOffset(0x7F)] private readonly byte arrowleft;

        [FieldOffset(0x80)] private readonly byte arrowright;
        [FieldOffset(0x81)] private readonly byte end;
        [FieldOffset(0x82)] private readonly byte arrowdown;
        [FieldOffset(0x83)] private readonly byte pageDown;
        [FieldOffset(0x84)] private readonly byte insert;
        [FieldOffset(0x85)] private readonly byte delete;
        [FieldOffset(0x86)] private readonly byte windows;

        public readonly bool Escape => escape == 255;
        public readonly bool One => one == 255;
        public readonly bool Two => two == 255;
        public readonly bool Three => three == 255;
        public readonly bool Four => four == 255;
        public readonly bool Five => five == 255;
        public readonly bool Six => six == 255;
        public readonly bool Seven => seven == 255;
        public readonly bool Eight => eight == 255;
        public readonly bool Nine => nine == 255;
        public readonly bool Zero => zero == 255;
        public readonly bool Dash => dash == 255;
        public readonly bool Backspace => backspace == 255;
        public readonly bool Tab => tab == 255;
        public readonly bool Q => q == 255;
        public readonly bool W => w == 255;
        public readonly bool E => e == 255;
        public readonly bool R => r == 255;
        public readonly bool T => t == 255;
        public readonly bool Y => y == 255;
        public readonly bool U => u == 255;
        public readonly bool I => i == 255;
        public readonly bool O => o == 255;
        public readonly bool P => p == 255;
        public new readonly bool Equals => equals == 255;
        public readonly bool Enter => enter == 255;
        public readonly bool LeftControl => leftControl == 255;
        public readonly bool A => a == 255;
        public readonly bool S => s == 255;
        public readonly bool D => d == 255;
        public readonly bool F => f == 255;
        public readonly bool G => g == 255;
        public readonly bool H => h == 255;
        public readonly bool J => j == 255;
        public readonly bool K => k == 255;
        public readonly bool L => l == 255;
        public readonly bool SemiColon => semicolon == 255;
        public readonly bool Apostrophe => apostrophe == 255;
        public readonly bool Hashtag => hashtag == 255;
        public readonly bool LeftShift => leftShift == 255;
        public readonly bool Z => z == 255;
        public readonly bool X => x == 255;
        public readonly bool C => c == 255;
        public readonly bool V => v == 255;
        public readonly bool B => b == 255;
        public readonly bool N => n == 255;
        public readonly bool M => m == 255;
        public readonly bool Comma => comma == 255;
        public readonly bool FullStop => fullstop == 255;
        public readonly bool ForwardSlash => forwardslash == 255;
        public readonly bool RightShift => rightshift == 255;
        public readonly bool NumpadAsterisk => numpadAsterisk == 255;
        public readonly bool Alt => alt == 255;
        public readonly bool Space => space == 255;
        public readonly bool CapsLock => capsLock == 255;
        public readonly bool NumLock => numLock == 255;
        public readonly bool ScrollLock => scrollLock == 255;
        public readonly bool NumpadSeven => numpadSeven == 255;
        public readonly bool NumpadEight => numpadEight == 255;
        public readonly bool NumpadNine => numpadNine == 255;
        public readonly bool NumpadDash => numpadDash == 255;
        public readonly bool NumpadFour => numpadFour == 255;
        public readonly bool NumpadFive => numpadFive == 255;
        public readonly bool NumpadSix => numpadSix == 255;
        public readonly bool NumpadPlus => numpadPlus == 255;
        public readonly bool NumpadOne => numpadOne == 255;
        public readonly bool NumpadTwo => numpadTwo == 255;
        public readonly bool NumpadThree => numpadThree == 255;
        public readonly bool NumpadZero => numpadZero == 255;
        public readonly bool NumpadFullstop => numpadFullstop == 255;
        public readonly bool Backtick => backtick == 255;
        public readonly bool Backslash => backslash == 255;
        public readonly bool SquareBracketLeft => squareBracketLeft == 255;
        public readonly bool SquareBracketRight => squareBracketRight == 255;
        public readonly bool NumpadEnter => numpadEnter == 255;
        public readonly bool RightControl => rightcontrol == 255;
        public readonly bool AltGr => altgr == 255;
        public readonly bool NumpadForwardSlash => numpadForwardslash == 255;
        public readonly bool PauseBreak => pauseBreak == 255;
        public readonly bool Home => home == 255;
        public readonly bool ArrowUp => arrowup == 255;
        public readonly bool ArrowDown => arrowdown == 255;
        public readonly bool ArrowLeft => arrowleft == 255;
        public readonly bool ArrowRight => arrowright == 255;
        public readonly bool PageUp => pageUp == 255;
        public readonly bool PageDown => pageDown == 255;
        public readonly bool Windows => windows == 255;
        public readonly bool End => end == 255;
        public readonly bool Insert => insert == 255;
        public readonly bool Delete => delete == 255;
    }
}
