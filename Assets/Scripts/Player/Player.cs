using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GarrikMiller.Player {

    [RequireComponent(typeof(Rigidbody2D))]
    public class Player : MonoBehaviour
    {
        #region State Variables
        public PlayerStatemachine StateMachine { get; private set; }

        public PlayerIdleState IdleState { get; private set; }
        public PlayerMoveState MoveState { get; private set; }

        [SerializeField] private PlayerData playerData;
        #endregion

        #region Components
        public PlayerInputHandler InputHandler { get; private set; }
        public Rigidbody2D RB { get; private set; }
        public Animator Anim { get; private set; }
        #endregion

        #region Other Variables
        #endregion

        #region Base Functions
        private void Awake() {
            StateMachine = new PlayerStatemachine();

            IdleState = new PlayerIdleState(this, StateMachine, playerData);
            MoveState = new PlayerMoveState(this, StateMachine, playerData);
        }

        private void Start() {
            InputHandler = GetComponent<PlayerInputHandler>();
            RB = GetComponent<Rigidbody2D>();
            Anim = GetComponentInChildren<Animator>();

            StateMachine.Initialize(IdleState);
        }

        private void Update() {
            StateMachine.CurrentState.FrameUpdate();
        }

        private void FixedUpdate() {
            StateMachine.CurrentState.PhysicsUpdate();
        }

        #region Collision and Triggers
        private void OnCollisionEnter2D(Collision2D collision)
        {
            StateMachine.CurrentState.CollisionEnterLogic(collision);
        }

        private void OnCollisionStay2D(Collision2D collision)
        {
            StateMachine.CurrentState.CollisionStayLogic(collision);
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            StateMachine.CurrentState.CollisionExitLogic(collision);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            StateMachine.CurrentState.TriggerEnterLogic(other);
        }

        private void OnTriggerStay2D(Collider2D other)
        {
            StateMachine.CurrentState.TriggerStayLogic(other);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            StateMachine.CurrentState.TriggerExitLogic(other);
        }
        #endregion
        #endregion

        #region Other Functions

        #endregion
    }
}

