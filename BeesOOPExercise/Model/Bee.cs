namespace BeesOOPExercise.Model
{
    public abstract class Bee
    {
        protected static string ErrorMessage = "Damage value must be a percentage";
            
        protected float _health = 100;

        public abstract void Damage(int number);
        
        public abstract bool IsDead();

        public float Health => _health;
    }
}