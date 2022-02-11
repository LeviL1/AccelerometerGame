using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteakCaught : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            ScoreManager.mg.score += 500f;
            Destroy(this.gameObject);
        }
    }
}
