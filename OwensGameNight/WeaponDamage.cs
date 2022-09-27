using System;

namespace OwensGameNight
{
    abstract class WeaponDamage
    {
        /*---- 屬性&支援欄位 ----*/
        /// <summary>武器的擲骰次數。</summary>
        public abstract int RollTimes { get; }
        /// <summary>存有計算出來的傷害。</summary>
        public int Damage { get; protected set; }
        

        private int roll;
        /// <summary>set 或 get 3D6 擲骰結果。</summary>
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }

        private bool magic;
        /// <summary>若有魔法效果為true，反之為false。</summary>
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }

        private bool flaming;
        /// <summary>若有火焰效果為true，反之為false。</summary>
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }

        /*------- 建構式 -------*/
        public WeaponDamage(int roll) => Roll = roll;

        /*-------- 方法 --------*/
        protected abstract void CalculateDamage();
    }
}