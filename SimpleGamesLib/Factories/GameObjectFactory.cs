using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using SimpleGamesLib.Models;
using SimpleGamesLib.Models.GameObjects;

namespace SimpleGamesLib.Factories
{
    internal class GameObjectFactory
    {
        Random rdm = new Random();

        public GameObject CreateGameObject(int height = 20, int width = 20)
        {
            int objectType = rdm.Next(0, 3);

            switch (objectType)
            {
                case 0:
                    return new Boulder(false, GeneratePosition(height,width), GeneratePosition(height,width));
                case 1:
                    return new Bush(true, GeneratePosition(height,width), GeneratePosition(height,width));
                default:
                    return new Chest(true, GeneratePosition(height,width), GeneratePosition(height,width));
            }
        }

        public int GeneratePosition(int min, int max)
        {
            int position = rdm.Next(min, max);
            return position;
        }
    }
}
