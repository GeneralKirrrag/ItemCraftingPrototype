using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GarrikMiller.Player {
    public class PlayerState
    {
        protected Player player;
        protected PlayerStatemachine statemachine;
        protected PlayerData playerData;

        protected float startTime;

        public PlayerState(Player player, PlayerStatemachine statemachine, PlayerData playerData)
        {
            this.player = player;
            this.statemachine = statemachine;
            this.playerData = playerData;
        }

        public virtual void Enter()
        {
            DoChecks();
            startTime = Time.time;
        }

        public virtual void Exit()
        {

        }

        public virtual void FrameUpdate()
        {

        }

        public virtual void PhysicsUpdate()
        {
            DoChecks();
        }

        public virtual void TriggerEnterLogic(Collider2D other)
        {

        }

        public virtual void TriggerStayLogic(Collider2D other)
        {

        }

        public virtual void TriggerExitLogic(Collider2D other)
        {

        }

        public virtual void CollisionEnterLogic(Collision2D other)
        {

        }

        public virtual void CollisionStayLogic(Collision2D other)
        {

        }

        public virtual void CollisionExitLogic(Collision2D other)
        {

        }

        public virtual void DoChecks()
        {

        }
    }
}