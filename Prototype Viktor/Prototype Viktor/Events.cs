using System;
using System.Linq;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Rendering;
using SharpDX;

namespace Prototype_Viktor
{
    public static class Events
    {


        static Events()
        {
            Orbwalker.OnPreAttack += Orbwalker_OnPreAttack;
        }

        public static void Initialize()
        {

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
