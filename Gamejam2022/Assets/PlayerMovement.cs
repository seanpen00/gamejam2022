using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;
    private float nextActionTime = 0.0f;
    public float period = 0.1f;

    [SerializeField] public float runSpeed = 3.0f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            // execute block of code here
            if (FlashlightPickup.myLight.intensity > 0f)
            {
                FlashlightPickup.myLight.intensity -= .1f;
            }
        }
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Flashlight")
        {
            FlashlightPickup.myLight.intensity = 1.5f;
        }
    }
}
