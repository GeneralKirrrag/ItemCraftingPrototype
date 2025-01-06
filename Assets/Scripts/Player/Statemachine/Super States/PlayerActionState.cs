using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GarrikMiller.Player
{
    public class PlayerActionState : PlayerState
    {
        public PlayerActionState(Player player, PlayerStatemachine statemachine, PlayerData playerData) : base(player, statemachine, playerData)
        {
        }
    }
}
