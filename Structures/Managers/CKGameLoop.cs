using AliceStructures.Game;
using System.Runtime.InteropServices;

namespace AliceStructures.Managers
{
	[StructLayout(LayoutKind.Explicit, Pack = 4)]
	public readonly unsafe struct CKGameLoop
	{
		[FieldOffset(0x24)] private readonly CKFileSystem* fileSystem;
		[FieldOffset(0x28)] private readonly CKServiceManager* serviceManager;
		[FieldOffset(0x2C)] private readonly CTimeManager* timeManager;
		[FieldOffset(0x30)] private readonly CKGraphic* graphics;
		[FieldOffset(0x34)] private readonly CRenderer* renderer;

		[FieldOffset(0x3C)] private readonly CKSoundManager* soundManager;
		[FieldOffset(0x40)] private readonly CKLoadingManager* loadingManager;
		[FieldOffset(0x44)] private readonly CKGameUIManager* uiManager;
		[FieldOffset(0x48)] private readonly CKSavingManager* savingManager;
		[FieldOffset(0x4C)] private readonly CKAliceGameManager* gameManager;
		[FieldOffset(0x50)] private readonly CKVirtualKeyboardManager* virtualKeyboardManager;
		[FieldOffset(0x54)] private readonly CKErrorManager* errorManager;

	}
}
