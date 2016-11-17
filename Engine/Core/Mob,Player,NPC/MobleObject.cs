using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class MobleObject
    {
        #region Fields
        private int _id;                // Holds the Moble's ID
        private string _name;           // Holds the name of the Moble
        private int _str;               // Hold the strength score
        private int _strMod;            // Holds strength Mod             
        private int _dex;               // Hold the Dexterity score
        private int _dexMod;            // Holds the Dexterity Mod
        private int _con;               // Hold the Constitution score
        private int _conMod;            // Holds the Constitution Mod
        private int _int;               // Hold the Intelligence score
        private int _intMod;            // Hold the Intelligence Mod
        private int _wis;               // Hold the Wisdom score
        private int _wisMod;            // Hold the Wisdom Mod
        private int _char;              // Hold the Charisma score
        private int _charMod;           // Hold the Charisma Mod
        private int _fort;              // Hold the Fortatude score
        private int _ref;               // Hold the Reflex score
        private int _will;              // Hold the Will score
        private int _currentHP;         // Hold CurrentHitPoints
        private int _maxHP;             // Hold the MaxHitPoints
        private int _ac;                // Hold the Armor Class
        private int _baseAttack;        // Hold the BaseAttck 
        private bool _isDead;           // Is the Moble dead
        private string _hitDie;         // Hold the Hit Dice;          
        private string _description;    // Description of MobleObject
        #endregion

        #region Properties
        public int ID { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public int Strength { get { return _str; } set { _str = value; } }
        public int StrengthMod { get { return _strMod; } set { _strMod = value; } }
        public int Dexterity { get { return _dex; } set { _dex = value; } }
        public int DexterityMod { get { return _dexMod; } set { _dexMod = value; } }
        public int Constitution { get { return _con; } set { _con = value; } }
        public int ConstitutionMod { get { return _conMod; } set { _conMod = value; } }
        public int Intelligence { get { return _int; } set { _int = value; } }
        public int IntelligenceMod { get { return _intMod; } set { _intMod = value; } }
        public int Wisdom { get { return _wis; } set { _wis = value; } }
        public int WisdomMod { get { return _wisMod; } set { _wisMod = value; } }
        public int Charisma { get { return _char; } set { _char = value; } }
        public int CharismaMod { get { return _charMod; } set { _charMod = value; } }
        public int Fortatude { get { return _fort; } set { _fort = value; } }
        public int Reflex { get { return _ref; } set { _ref = value; } }
        public int Will { get { return _will; } set { _will = value; } }
        public int CurrentHP { get { return _currentHP; } set { _currentHP = value; } }
        public int MaxHP { get { return _maxHP; } set { _maxHP = value; } }
        public int ArmorClass { get { return _ac; } set { _ac = value; } }
        public int BaseAttack { get { return _baseAttack; } set { _baseAttack = value; } }
        public bool IsDead { get { return _isDead; } set { _isDead = value; } }
        public string HitDie { get { return _hitDie; } set { _hitDie = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        #endregion

        #region Constructors
        // This constructor is used to create a new player.
        public MobleObject(int id, string name, int str, int dex, int con, int intel, int wis, int charisma)
        {
            this.ID = id;
            this.Name = name;
            this.Strength = str;
            this.Dexterity = dex;
            this.Constitution = con;
            this.Intelligence = intel;
            this.Wisdom = wis;
            this.Charisma = charisma;
            determineMods();
            this.Fortatude = determineFort(ConstitutionMod);
            this.Reflex = determineReflex(DexterityMod);
            this.Will = determineWill(WisdomMod);
            this.CurrentHP = determineHP();
            this.MaxHP = this.CurrentHP;
            this.ArmorClass = determineAC(dex);
            this.BaseAttack = determineBA();
            this.IsDead = false;
        }

        // Tbis constructor is for loading existing players back into the game.
        public MobleObject(int id, string name, int str, int dex, int con, int intel, int wis, int charisma, int fort, int reflex, int will,
                            int currentHp, int maxHp, int ac, int baseattack)
        {
            this.ID = id;
            this.Name = name;
            this.Strength = str;
            this.Dexterity = dex;
            this.Constitution = con;
            this.Intelligence = intel;
            this.Wisdom = wis;
            this.Charisma = charisma;
            this.Fortatude = fort;
            this.Reflex = reflex;
            this.Will = will;
            this.CurrentHP = currentHp;
            this.MaxHP = maxHp;
            this.ArmorClass = ac;
            this.BaseAttack = baseattack;
            this.IsDead = false;
        }
        #endregion

        // This Method will determine the modifiers for each stat.
        // This will later be modified by player race.
        private void determineMods()
        {
            StrengthMod = AbilityMod(Strength);
            DexterityMod = AbilityMod(Dexterity);
            ConstitutionMod = AbilityMod(Constitution);
            IntelligenceMod = AbilityMod(Intelligence);
            WisdomMod = AbilityMod(Wisdom);
            CharismaMod = AbilityMod(Charisma); 
        }

        private int determineFort(int conMod)
        {
            return Fortatude = conMod;
        }

        private int determineReflex(int dex)
        {
            return AbilityMod(dex);
        }

        private int determineWill(int wis)
        {
            return AbilityMod(wis);
        }

        private int determineHP()
        {
            return 0;
        }

        private int determineAC(int dex)
        {
            return (10 + Modifiers.DexMod(dex));
        }

        private int determineBA()
        {
            return 0;
        }

        public int AbilityMod(int abil)
        {
            int mod = 0;

            switch (abil)
            {
                case 1:
                    {
                        mod = -5;
                        break;
                    }
                case 2:
                case 3:
                    {
                        mod = -4;
                        break;
                    }
                case 4:
                case 5:
                    {
                        mod = -3;
                        break;
                    }
                case 6:
                case 7:
                    {
                        mod = -2;
                        break;
                    }
                case 8:
                case 9:
                    {
                        mod = -1;
                        break;
                    }
                case 10:
                case 11:
                    {
                        mod = 0;
                        break;
                    }
                case 12:
                case 13:
                    {
                        mod = 1;
                        break;
                    }
                case 14:
                case 15:
                    {
                        mod = 2;
                        break;
                    }
                case 16:
                case 17:
                    {
                        mod = 3;
                        break;
                    }
                case 18:
                case 19:
                    {
                        mod = 4;
                        break;
                    }
                case 20:
                case 21:
                    {
                        mod = 5;
                        break;
                    }
                case 22:
                case 23:
                    {
                        mod = 6;
                        break;
                    }
                case 24:
                case 25:
                    {
                        mod = 7;
                        break;
                    }
                case 26:
                case 27:
                    {
                        mod = 8;
                        break;
                    }
                case 28:
                case 29:
                    {
                        mod = 9;
                        break;
                    }
                case 30:
                case 31:
                    {
                        mod = 10;
                        break;
                    }
                case 32:
                case 33:
                    {
                        mod = 11;
                        break;
                    }
                case 34:
                case 35:
                    {
                        mod = 12;
                        break;
                    }
                case 36:
                case 37:
                    {
                        mod = 13;
                        break;
                    }
                case 38:
                case 39:
                    {
                        mod = 14;
                        break;
                    }
                case 40:
                case 41:
                    {
                        mod = 15;
                        break;
                    }
                case 42:
                case 43:
                    {
                        mod = 16;
                        break;
                    }
                case 44:
                case 45:
                    {
                        mod = 17;
                        break;
                    }
            }

            return mod;
        }

        public string HitDice
    }
}

