﻿using Game.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Equipment.Weapons
{
    public class Knife : IIncreaseAttack
    {
        public void IncreaseAttack()
        {
            int increaseAttack = 2;
        }
    }
}
