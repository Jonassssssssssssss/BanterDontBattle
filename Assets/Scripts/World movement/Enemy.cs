using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform playerTransform; // Assign the player's transform in the Inspector
        public float moveSpeed = 3f;
        private bool playerDetected = false;

        public GameObject alert;

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                
                playerDetected = true;
                alert.SetActive(true);
                
                
            }
        }

        

        void Update()
        {
            if (playerDetected && playerTransform != null)
            {
                StartCoroutine(ExecuteAfterSeconds(2f)); 
                //transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, moveSpeed * Time.deltaTime);
            }
        }

        IEnumerator ExecuteAfterSeconds(float delayTime)
        {
            // Wait for the specified amount of seconds
            yield return new WaitForSeconds(delayTime);
            alert.SetActive(false);
            transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, moveSpeed * Time.deltaTime);

            
        }
}
