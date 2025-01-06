using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Forge : MonoBehaviour
{
    public InputAction inputAction;
    private bool playerInRange;
    [SerializeField] private LayerMask playerLayer;

    public ForgeMeter forgeMeter;

    private void Awake()
    {
        inputAction.performed += StartHeating;
        inputAction.canceled += StopHeating;
    }

    private void OnEnable() => inputAction.Enable();
    private void OnDisable() => inputAction.Disable();

    private void OnTriggerEnter2D(Collider2D other) {
        if (((1 << other.gameObject.layer) & playerLayer) != 0) {
            Debug.Log("Player Enter");
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (((1 << other.gameObject.layer) & playerLayer) != 0) {
            playerInRange = false;
        }
    }

    public void StartHeating(InputAction.CallbackContext context) {
        if (playerInRange) forgeMeter.isHeating = true;
        else forgeMeter.isHeating = false;
    }

    public void StopHeating(InputAction.CallbackContext context) {
        forgeMeter.isHeating = false;
    }
}
