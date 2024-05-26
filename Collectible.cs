/*
* Author: Sia yong hong
* Date of creation: 18th May 2024
* Description: Code for collectibles
*/
using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    int coinpoints = 5;

    
    /// <summary>
    /// The score value that this collectible is worth.
    /// </summary>
    public int myScore = 5;

    /// <summary>
    /// Performs actions related to collection of the collectible
    /// </summary>
    public void Collected()
    {
        // Destroy the attached GameObject
        Destroy(gameObject);
    }

    /// <summary>
    /// Callback function for when a collision occurs
    /// </summary>
    /// <param name="collision">Collision event data</param>
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object that
        // touched me has a 'Player' tag
        if ((collision.gameObject.tag == "Player") && (gameObject.tag == "coin"));
        {
            collision.gameObject.GetComponent<Player>().IncreaseScore(coinpoints);
            Collected();
        }
    }

    // Used to make the collectibles rotate constantly
    void Update()
    {
        transform.Rotate(0f, 0f, 100 * Time.deltaTime, Space.Self);
    }


}
