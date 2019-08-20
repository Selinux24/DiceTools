
namespace DiceTools
{
    using DiceTools.Units.ImperialKnights;
    using DiceTools.Units.Orks;
    using DiceTools.Units.SpaceWolves;

    public class UnitGen
    {
        public Unit GetAttacker()
        {
            //var unit = WarBikers.Create(true, 5);
            //var unit = BurnaBoyz.Create(0, 10);
            //var unit = Lootas.Create(0, 8);
            //var unit = Boyz.Create(false, 27, 0, 3);
            //var unit = FlashGitz.Create(true, 4, 1);
            //var unit = Intercessors.Create(true, 4);
            //var unit = Hellblasters.Create(true, 4);
            //var unit = Razorback.Create(RazorBackTypes.LasscannonAndTwinPlasmaGun, true, true);
            //var unit = MekGunz.Create(MekGunzTypes.SmashaGun, 5);
            //var unit = GreyHunters.Create(true, false, true, 4, 0, 1);
            //var unit = Gunwagon.Create(GunwagonTypes.Default, 4);
            //var unit = LandSpeeders.Create(LandSpeederTypes.MeltaCannon, LandSpeederWeaponTypes.AssaultCannon, 1);
            //var unit = ArmigerHelverin.Create(ArmigerHelverinTypes.Meltagun);
            //var unit = ArmigerWarglaive.Create(ArmigerWarglaiveTypes.Meltagun);
            //var unit = KnightPreceptor.Create(KnightPreceptorTypes.Meltagun);
            //var unit = DeffkillaWartrike.Create();
            var unit = BigMek.Create(true);
            //var unit = Gretchin.Create(30);

            return unit;
        }

        public Unit GetDefender()
        {
            //var unit = GreyHunters.Create(true, false, true, 4, 1, 0);
            //var unit = LandSpeeders.Create(LandSpeederTypes.Default, LandSpeederWeaponTypes.AssaultCannon, 3);
            //var unit = Intercessors.Create(true, 4);
            //var unit = WarBikers.Create(true, 5);
            //var unit = Boyz.Create(false, 27, 0, 3);
            //var unit = ArmigerWarglaive.Create(ArmigerWarglaiveTypes.Default);
            //var unit = KnightPreceptor.Create(KnightPreceptorTypes.Default);
            //var unit = Gunwagon.Create(GunwagonTypes.ZzapGun, 4);
            //var unit = ArmigerHelverin.Create(ArmigerHelverinTypes.Default);
            var unit = Rhino.Create();
            //var unit = Razorback.Create(RazorBackTypes.TwinHeavyBolter, true, true);

            return unit;
        }
    }
}
