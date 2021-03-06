﻿using System;

namespace BeesOOPExercise.Model
{
    public class Drone : Bee
    {

        public override void Damage(int number)
        {
            if (number > 100 || number < 0)
            {
                throw new Exception(ErrorMessage);
            }

            if (_health >= 50)
            {
                _health = _health - _health * ((float)number / 100);
            }
        }

        public override bool IsDead() => _health < 50;
        
    }
}