using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace SimpleGamesLib
{
    public class Creature
    {
        private int _baseHealth;
        private int _baseDamage;
        private int _baseDefense;
        private decimal _position;

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

        public int Defend(int incomingDamage)
        {
            incomingDamage -= GetDefenseValue();

            if (incomingDamage > 0) _baseHealth -= incomingDamage;

            return _baseHealth;
        }

        public void Loot(Item i)
        {
            if (i != null) Items.Add(item: i);
        }
    }
}