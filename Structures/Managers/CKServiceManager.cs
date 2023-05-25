using AliceStructures.Services;
using System.Runtime.InteropServices;

namespace AliceStructures.Managers
{
	[StructLayout(LayoutKind.Explicit, Pack = 4)]
	public readonly unsafe struct CKServiceManager
	{
		[FieldOffset(0x2C)] private readonly CKSrvCamera* camera;

		public readonly CKSrvCamera* Camera => camera;
	}
}
