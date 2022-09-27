using System;

namespace OwensGameNight
{
    class SwordDamage : WeaponDamage
    {
        /*-------- 常數 --------*/
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;
        public const decimal MAGIC_MULTI = 2M;

        /*---- 屬性&支援欄位 ----*/
        public override int RollTimes { get { return 3; } }

        /*------- 建構式 -------*/
        public SwordDamage(int roll) : base(roll)
        {
            Roll = roll;
            CalculateDamage();
        }

        /*-------- 方法 --------*/
        protected override void CalculateDamage()
        {
            decimal magicMulti = (Magic) ? MAGIC_MULTI : 1M;
            Damage = (int)(Roll * magicMulti) + BASE_DAMAGE;

            if (Flaming) 
                Damage += FLAME_DAMAGE;
        }
    }
}