using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class flat : MonoBehaviour
{
     public float bounceCooldown = 0.5f; // Cooldown time between bounces

    private float lastBounceTime;
    private int counter = 0;
    private Rigidbody rb;

    public Text counterText;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        lastBounceTime = Time.time;
    }

    private void OnCollisionEnter(Collision platform)
    {
        if (platform.gameObject.CompareTag("Ground") && (Time.time - lastBounceTime) > bounceCooldown)
        {
            counter++;
            Debug.Log("Collision Count: " + counter);
            lastBounceTime = Time.time;

            // Update the UI text
            UpdatecounterText();
        }
    }
    private void UpdatecounterText()
    {
        if (counterText != null)
        {
            counterText.text = "Collision Count: " + counter;
        }
    }
}