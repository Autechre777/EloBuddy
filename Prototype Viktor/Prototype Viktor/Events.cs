using System;
using System.Linq;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Rendering;
using SharpDX;

namespace Protype_Viktor
{
    public static class Events
    {


        static Events()
        {
            Orbwalker.OnPreAttack += Orbwalker_OnPreAttack;
            Chat.Print("66666666666666666" + version + " 66666666666666666");
        }

        public static void Initialize()
        {
        Chat.Print("66666666666666666" + version + " 66666666666666666");
        }

        private static void Orbwalker_OnPreAttack(AttackableUnit target, Orbwalker.PreAttackArgs args)
        {
            var a = target as Obj_AI_Minion;

            if (a == null)
            {
                return;
            }

            if (a !== null)
            {
                args.Process = false;
            }
        }

        
    }
}
