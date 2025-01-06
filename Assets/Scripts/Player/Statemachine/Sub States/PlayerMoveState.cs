using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.ShortcutManagement;
using UnityEngine;

namespace GarrikMiller.Player
{
    public class PlayerMoveState : PlayerBaseState
    {
        public bool startCoroutine;
        private float moveSpeed;

        public PlayerMoveState(Player player, PlayerStatemachine statemachine, PlayerData playerData) : base(player, statemachine, playerData)
        {
        }

        public override void Enter()
        {
            base.Enter();

            startCoroutine = true;

            //Debug.Log("Move Entered");
            //player.Anim.Play("Run");

            moveSpeed = playerData.moveSpeed;
        }

        public override void FrameUpdate()
        {
            base.FrameUpdate();

            if (startCoroutine) {
                startCoroutine = false;
            }

            player.RB.velocity = new Vector2(moveSpeed * input.x, moveSpeed * input.y);

            if (input == Vector2.zero) {
                statemachine.ChangeState(player.IdleState);
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
