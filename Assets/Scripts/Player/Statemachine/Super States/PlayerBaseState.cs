using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GarrikMiller.Player
{
    public class PlayerBaseState : PlayerState
    {
        protected Vector2 input;

        public PlayerBaseState(Player player, PlayerStatemachine statemachine, PlayerData playerData) : base(player, statemachine, playerData)
        {
        }

        public override void Enter()
        {
            base.Enter();
        }

        public override void FrameUpdate()
        {
            base.FrameUpdate();

            input = player.InputHandler.MovementInput;
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();
        }

        public override void DoChecks()
        {
            base.DoChecks();
        }

        public override void Exit()
        {
            base.Exit();
        }

    }
}
