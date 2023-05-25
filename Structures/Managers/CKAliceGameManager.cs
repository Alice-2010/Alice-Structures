using AliceStructures.Graphics;
using System.Runtime.InteropServices;

namespace AliceStructures.Game
{
    [StructLayout(LayoutKind.Explicit, Pack = 4)]
    public readonly unsafe struct CKAliceGameManager
    {
        [FieldOffset(0x4)] private readonly CKGrpAliceEnemy* grpAliceEnemy;
        [FieldOffset(0x8)] private readonly CKGrpAliceHero* grpAliceHero;
        [FieldOffset(0xC)] private readonly CKGrpMeca* grpMeca;
        [FieldOffset(0x10)] private readonly CKGrpBonus* grpBonus;
        [FieldOffset(0x14)] private readonly CKGrpLevelManager* grpLevelManager;
        [FieldOffset(0x18)] private readonly CKLevel* level;

        [FieldOffset(0x3C)] private readonly CKFileMem* fileMem;
        [FieldOffset(0x40)] private readonly CKAlicePlayer* character1;
        [FieldOffset(0x44)] private readonly CKAlicePlayer* character2;
        [FieldOffset(0x48)] private readonly CKAlicePlayer* character3;
        [FieldOffset(0x4C)] private readonly CKAlicePlayer* character4;
        [FieldOffset(0x50)] private readonly CKAlicePlayer* character5;
        [FieldOffset(0x54)] private readonly CKAlicePlayer* character6;
        [FieldOffset(0x58)] private readonly CKAlicePlayer* character7;
        [FieldOffset(0x5C)] private readonly CKAlicePlayer* character8;

        [FieldOffset(0x6C)] private readonly CKAliceGameStructure* gameStructure;

        [FieldOffset(0x84)] private readonly WIN32_CKVideo* loadingVideo;

        [FieldOffset(0x190)] private readonly CKLocTextAccessor* locTextAccessor;

        [FieldOffset(0x1A4)] private readonly CFileIOManager* fileIOManager;
        [FieldOffset(0x1A8)] private readonly CMCManager* cmcManager;
        [FieldOffset(0x1AC)] private readonly CKSavingManager* savingManager;
        [FieldOffset(0x1B0)] private readonly CKLoadingManager* loadingManager;

        public readonly CKGrpAliceEnemy* GrpAliceEnemy => grpAliceEnemy;

        public readonly CKAliceGameStructure* GameStructure => gameStructure;

        public readonly WIN32_CKVideo* LoadingVideo => loadingVideo;
    }
}
