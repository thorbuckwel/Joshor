using System.ComponentModel;

namespace Engine
{
    public class LivingCreature : INotifyPropertyChanged
    {
        #region Fields
        private static int _currentHitPoints;                                // Varable to hold the current hitpoints?
        private bool _isDead;                                                // We need to know if they are dead right?
        private bool _canBeAttacked;                                         // Can the creature be attacked?
        private static int _maximumHitPoints;                                // This give use access to the maximum HP the living creature will have.
        private Factions _faction;
        #endregion

        /**
         * The properties to allow use access to the private variables
         */
        #region Properties
        public int CurrentHitPoints { get { return _currentHitPoints; } set { _currentHitPoints = value; } }
        public bool IsDead { get { return _isDead;} set { _isDead = value; }}
        public bool CanBeAttacked { get { return _canBeAttacked; } set { _canBeAttacked = value; } }
        public int MaximumHitPoints { get { return _maximumHitPoints; } set { _maximumHitPoints = value;} }
        public Factions Factions { get { return _faction; } set { _faction = value; } }
        #endregion

        // This is a const to create a livinig creature. This is the base.
        #region Constructor
        public LivingCreature(int currentHitPoints, int maximumHitPoints, bool isDead, bool canBeAttacked, Factions faction)   
        {
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints;
            IsDead = isDead;
            CanBeAttacked = canBeAttacked;
            Factions = faction;
        }
        #endregion

        /*
         * If anything in these varables change we need a method to read this and send it to the proper interface.
        */
        #region Property Change
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion
    }
}