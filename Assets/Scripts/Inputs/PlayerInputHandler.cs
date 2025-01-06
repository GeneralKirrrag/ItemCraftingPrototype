using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GarrikMiller.Player
{
    [RequireComponent(typeof(PlayerInput))]
    public class PlayerInputHandler : MonoBehaviour
    {
        public Vector2 MovementInput { get; private set; }

        public void OnMovementInput(InputAction.CallbackContext context) {
            MovementInput = context.ReadValue<Vector2>();
        }
    }
}

