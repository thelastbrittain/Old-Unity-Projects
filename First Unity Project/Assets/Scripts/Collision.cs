﻿using UnityEngine;

public class Collision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter (UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; 
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }
    



}
// void OnCollisionEnter (UnityEngine.Collision collisionInfo) 
//     {
//         Debug.Log(collisionInfo.gameObject.name);