using System.ComponentModel;

namespace Engine
{
    public class LivingCreature : INotifyPropertyChanged
    {
        public static int _currentHitPoints;                                // Varable to hold the current hitpoints

        public int CurrentHitPoints                                          // This gives us a way to set and get info from the varable. 
        {get { return _currentHitPoints; } set{_currentHitPoints = value; OnPropertyChanged("CurrentHitPoints");}}

        public static int MaximumHitPoints { get; set; }                    // This give use access to the maximum HP the living creature will have

        private bool isDead;        // We need to know if they are dead right?

        public bool IsDead
        {
            get { return isDead; }
            set { isDead = value; }
        }

        public LivingCreature(int currentHitPoints, int maximumHitPoints, bool isDead)   // This is a const to create a livinig creature. This is the base.
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