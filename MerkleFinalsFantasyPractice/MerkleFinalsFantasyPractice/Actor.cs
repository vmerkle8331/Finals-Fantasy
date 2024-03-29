using System;
using System.Collections.Generic;
using System.Text;

namespace MerkleFinalsFantasyPractice
{
    public class Actor
    {
        #region feilds
        private string name;
        private string spriteName;
        private int hitPoints;
        private int speed;
        private int strength;
        private int intelligence;
        private int defense;
        private int magicDefense;
        private bool isDefending;
        #endregion

        public Actor(string name, string spriteName, int hitPoints, int speed, int strength, int intelligence, int defense, int magicDefense, bool isDefending)
        {
            this.name = name;
            this.spriteName = spriteName;
            this.hitPoints = hitPoints;
            this.speed = speed;
            this.strength = strength;
            this.intelligence = intelligence;
            this.defense = defense;
            this.magicDefense = magicDefense;
            this.isDefending = isDefending;
        }

        public Actor()
        {
            name = "Vthryl";
            spriteName = "Emblem";
        }

        #region Properties
        public string Name { get => name; set => name = value; }
        public string SpriteName { get => spriteName; set => spriteName = value; }
        public int HitPoints { get => hitPoints; set => hitPoints = value; }
        public int Speed { get => speed; set => speed = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }
        public int Defense { get => defense; set => defense = value; }
        public int MagicDefense { get => magicDefense; set => magicDefense = value; }
        public bool IsDefending { get => isDefending; set => isDefending = value; }
        #endregion

        public void Attack(Actor target)
        {
            throw new System.NotImplementedException();
        }

        public void Defend()
        {
            throw new System.NotImplementedException();
        }
    }
}