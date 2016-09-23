using System.ComponentModel;

namespace Engine
{
    public class LivingCreature : INotifyPropertyChanged
    {
        private static int _currentHitPoints;                                // Varable to hold the current hitpoints
        private bool _isDead;                                                // We need to know if they are dead right?
        private static int _maximumHitPoints { get; set; }                   // This give use access to the maximum HP the living creature will have

        /**
         * The properties to allow use access to the private variables
         */
        public int CurrentHitPoints { get { return _currentHitPoints; } set { _currentHitPoints = value; } }
        public bool IsDead { get { return _isDead;} set { _isDead = value; }}
        public int MaximumHitPoints { get { return _maximumHitPoints; } set { _maximumHitPoints = value;} }

        // This is a const to create a livinig creature. This is the base.
        public LivingCreature(int currentHitPoints, int maximumHitPoints, bool isDead)   
        {
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints;
            IsDead = isDead;
        }

        /*
         * If anything in these varables change we need a method to read this and send it to the proper interface.
        */

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}