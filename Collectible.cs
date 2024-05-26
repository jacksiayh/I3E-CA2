/*
* Author: Sia Yong Hong
* Date of creation: 26th May 2024
* Description: Code for all the collectibles
*/
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using StarterAssets;
public class Collectible : MonoBehaviour
{
    public void AddSpeed(Collider other)
    {
        other.gameObject.GetComponent<FirstPersonController>().MoveSpeed = 100.0f;
    }
    public void AddJump(Collider other)
    {
        other.gameObject.GetComponent<FirstPersonController>().JumpHeight = 100.0f;
    }
}
