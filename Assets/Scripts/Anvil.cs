using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Anvil : MonoBehaviour
{
    public InputAction inputAction;
    private bool playerInRange;
    [SerializeField] private LayerMask playerLayer;

    public ForgeMeter forgeMeter;

    public float strikeCooldown = 0.5f;
    private float timer;

    private void Awake()
    {
        inputAction.performed += HammerInput;
    }

    private void OnEnable() => inputAction.Enable();
    private void OnDisable() => inputAction.Disable();

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (((1 << other.gameObject.layer) & playerLayer) != 0)
        {
            Debug.Log("Player Enter");
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (((1 << other.gameObject.layer) & playerLayer) != 0)
        {
            playerInRange = false;
        }
    }

    private void Update()
    {
        if (timer > 0f)
        {
            timer -= Time.deltaTime;
        }
    }

    public void HammerInput(InputAction.CallbackContext context)
    {
        if (playerInRange && timer <= 0f)
        {
            forgeMeter.Strike();
            timer = strikeCooldown;
        }
    }
}
