using System;
using UnityEngine;

namespace _Project.CodeBase.Data
{
    [Serializable]
    public class PlayerProgress
    {
        public WorldData WorldData;

        public PlayerProgress(string initialLevel) => 
            WorldData = new WorldData(initialLevel);
    }
} 