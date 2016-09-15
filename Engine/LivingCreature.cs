using System.ComponentModel;

namespace Engine
{
    public class LivingCreature : INotifyPropertyChanged
    {
        public int _currentHitPoints;                  // Varable to hold the current hitpoints

        public int CurrentHitPoints                     // This gives us a way to set and get info from the varable. 
        {
            get { return _currentHitPoints; }
            set
            {
                _currentHitPoints = value;
                OnPropertyChanged("CurrentHitPoints");
            }
        }

        public int MaximumHitPoints { get; set; }      // This give use access to the maximum HP the living creature will have

        public bool IsDead { get { return CurrentHitPoints <= 0; } }  // We need to know if they are dead right?

        public LivingCreature(int currentHitPoints, int maximumHitPoints)   // This is a const to create a livinig creature. This is the base.
        {
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints;
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