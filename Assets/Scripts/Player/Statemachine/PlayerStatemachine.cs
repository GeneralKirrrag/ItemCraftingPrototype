using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GarrikMiller.Player {
    public class PlayerStatemachine
    {
        public PlayerState CurrentState { get; private set; }

        public void Initialize(PlayerState startingState)
        {
            CurrentState = startingState;
            CurrentState.Enter();
        }

        public void ChangeState(PlayerState newState)
        {
            CurrentState.Exit();
            CurrentState = newState;
            CurrentState.Enter();
        }
    }
}

