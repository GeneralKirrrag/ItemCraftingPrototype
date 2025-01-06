using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GarrikMiller.Player
{
    public class PlayerIdleState : PlayerBaseState
    {
        public PlayerIdleState(Player player, PlayerStatemachine statemachine, PlayerData playerData) : base(player, statemachine, playerData)
        {
        }

        public override void Enter()
        {
            base.Enter();

            //Debug.Log("Idle Entered");
            //player.Anim.Play("Idle");
        }

        public override void FrameUpdate()
        {
            base.FrameUpdate();

            player.RB.velocity.Set(0f, 0f);

            if (input != Vector2.zero) {
                statemachine.ChangeState(player.MoveState);
            }
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
