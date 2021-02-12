using System;

namespace BeesOOPExercise.Model
{
    public class Worker : Bee
    {
        public override void Damage(int number)
        {
            if (number > 100 || number < 0)
            {
                throw new Exception(ErrorMessage);
            }

            if (_health >= 70)
            {
                _health = _health - _health * ((float)number / 100);
            }
        }

        public override bool IsDead() => _health < 70;
    }
}