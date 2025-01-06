using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Forge : MonoBehaviour
{
    public InputAction inputAction;
    private bool playerInRange;

    private void Awake()
    {
        inputAction.performed += StartHeating;
        inputAction.canceled += StopHeating;
    }

    private void OnEnable() => inputAction.Enable();
    private void OnDisable() => inputAction.Disable();

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player")) {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player")) {
            playerInRange = false;
        }
    }

    public void StartHeating(InputAction.CallbackContext context) {
        Debug.Log("Heating: True");
    }

    public void StopHeating(InputAction.CallbackContext context) {
        Debug.Log("Heating: False");
    }
}
