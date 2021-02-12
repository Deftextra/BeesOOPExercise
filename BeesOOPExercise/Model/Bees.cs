using System;
using System.Collections.Generic;

namespace BeesOOPExercise.Model
{
    public class BeesData
    {
        private List<Bee> _bees = new List<Bee>
        {
            new Drone(),
            new Queen(),
            new Worker(),
            new Queen(),
            new Worker(),
            new Worker(),
            new Worker(),
            new Worker(),
            new Worker(),
            new Drone(),
        };

        public IEnumerable<Bee> Bees => _bees;

        public void DamageAll()
        {
            
            Random random = new Random();

            foreach (var bee in _bees)
            {
                int DamageValue = random.Next(0, 100);
                bee.Damage(DamageValue);
            }
        }
        
        public void AddBee(Bee bee)
        {
            _bees.Add(bee);
        }
    }
}