using System;

namespace OwensGameNight
{
    class ArrowDamage : WeaponDamage
    {
        /*-------- 常數 --------*/
        public const decimal BASE_MULTI = 0.35M;
        public const decimal MAGIC_MULTI = 2.5M;
        public const decimal FLAME_DAMAGE = 1.25M;

        /*---- 屬性&支援欄位 ----*/
        public override int RollTimes { get { return 1; } }

        /*------- 建構式 -------*/
        public ArrowDamage(int roll) : base(roll)
        {
            Roll = roll;
            CalculateDamage();
        }

        /*-------- 方法 --------*/
        protected override void CalculateDamage()
        {
            decimal baseDmg = Roll * BASE_MULTI;

            if (Magic) 
                baseDmg *= MAGIC_MULTI;

            if (Flaming)
                Damage = (int)Math.Ceiling(baseDmg + FLAME_DAMAGE);
            else
                Damage = (int)Math.Ceiling(baseDmg);
        }
    }
}