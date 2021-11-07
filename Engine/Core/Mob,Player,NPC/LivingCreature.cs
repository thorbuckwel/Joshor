using System.ComponentModel;

namespace Engine
{
    public class LivingCreature : INotifyPropertyChanged
    {
        /**
         * The properties to allow use access to the private variables
         */
        #region Properties
        public int ID { get; set; }
        public int CurrentHitPoints { get; set; }
        public bool IsDead { get; set; }
        public bool CanBeAttacked { get; set; }
        public int MaximumHitPoints { get; set; }
        public Factions Factions { get; set; }
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