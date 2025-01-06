using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GarrikMiller.Player {
    [CreateAssetMenu(fileName = "New Player Data", menuName = "Data/Player Data")]
    public class PlayerData : ScriptableObject
    {
        public float moveSpeed = 5f;
        public float chaseMultiplier = 1.2f;
        public float chaseStopTime = 3f;
    }
}

