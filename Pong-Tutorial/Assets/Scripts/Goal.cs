using System;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private bool isPlayer1;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Ball"))
        {
            if (isPlayer1)
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().Player2Scored();
            }
            else
            {
                
                GameObject.Find("GameManager").GetComponent<GameManager>().Player1Scored();
            } 
        }
        
    }
}