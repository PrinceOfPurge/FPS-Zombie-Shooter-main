using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Announcer1 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object is the player
        if (collision.collider.CompareTag("Player"))
        {
            // Play the sound
            AudioManager.instance.PlayOneShot(FMODEvents.instance.Announcer1, this.transform.position);
        }
    }
}
