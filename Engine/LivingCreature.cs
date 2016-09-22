using System.ComponentModel;

namespace Engine
{
    public class LivingCreature : INotifyPropertyChanged
    {
        public string Name { get; private set; }
        public int ArmorClass { get; private set; }
        public virtual int MaximumHitPoints { get; protected set; }

        protected int _currentHitPoints;
        public virtual int CurrentHitPoints
        {
            get
            {
                return _currentHitPoints;
            }

            set
            {
                _currentHitPoints = value;
                OnPropertyChanged("CurrentHitPoints");
            }
        }

        public bool HasTakenFatalDamage
        {
            get
            {
                return (CurrentHitPoints <= 0);
            }
        }
        
        public LivingCreature(int maximumHitPoints, string name, int armorClass)   
        {
            CurrentHitPoints = maximumHitPoints;
            MaximumHitPoints = maximumHitPoints;
            Name = name;
            ArmorClass = armorClass;
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