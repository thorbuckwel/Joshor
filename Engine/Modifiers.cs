using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Modifiers
    {
        public static int AbilityMod(int abil)
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
    }
}
