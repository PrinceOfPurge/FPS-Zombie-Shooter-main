using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Announcer2 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object is the player
        if (collision.collider.CompareTag("Player"))
        {
            // Play the sound
            AudioManager.instance.PlayOneShot(FMODEvents.instance.Announcer2, this.transform.position);
        }
    }
}
