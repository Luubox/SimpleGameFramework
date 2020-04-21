using System.Collections.Generic;
using System.Linq;
using SimpleGamesLib.Interfaces;

namespace SimpleGamesLib.Models
{
    public class Alive : IState
    {
        private static Alive instance = new Alive();
        public static Alive GetInstance => instance;

        private Alive() { }

        public void Interact(Creature creature)
        {
            //engage combat
        }
    }
    public class Dead : IState
    {
        private static Dead instance = new Dead();
        public static Dead GetInstance => instance;

        private Dead() { }

        public void Interact(Creature creature)
        {
            //loot or walk through
        }
    }

    public class Creature
    {
        //TODO Differentiate NPCs from Player Characters

        private IState _state;
        private int _baseHealth;
        private int _baseDamage;
        private int _baseDefense;
        private decimal _position;
        public IState State
        {
            set => _state = value;
        }

        public int BaseHealth
        {
            get => _baseHealth;
            set => _baseHealth = value;
        }

        public int BaseDamage
        {
            get => _baseDamage;
            set => _baseDamage = value;
        }

        public int BaseDefense
        {
            get => _baseDefense;
            set => _baseDefense = value;
        }

        public decimal Position
        {
            get => _position;
            set => _position = value;
        }

        public List<Item> Items { get; set; }

        public Creature()
        {
            _state = Alive.GetInstance;
        }
        
        //public int GetEffectiveHealthValue()
        //{
        //    return BaseHealth * Buffs.FindAll(i => i.Type == "Health").Sum(i => i.Value);
        //}

        public int GetAttackValue()
        {
            return BaseDamage + Items.FindAll(i => i.Type == "Offensive").Sum(i => i.Value);
            //TODO buff check
        }
        
        public int GetDefenseValue()
        {
            return BaseDefense + Items.FindAll(i => i.Type == "Defensive").Sum(i => i.Value);
        }

        public int Attack()
        {
           return GetAttackValue();
        }

        public void Defend(int incomingDamage)
        {
            incomingDamage -= GetDefenseValue();

            if (incomingDamage > 0) _baseHealth -= incomingDamage;

            if (_baseHealth <= 0) _state = Dead.GetInstance;
        }

        public void Loot(Item i)
        {
            if (i != null) Items.Add(item: i);
        }
        
    }
}