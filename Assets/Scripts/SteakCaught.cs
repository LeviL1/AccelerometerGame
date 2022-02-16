using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteakCaught : MonoBehaviour
{
  private ButcherController butcher;
  private void Awake()
  {
    butcher = GameObject.FindGameObjectWithTag("Butcher").GetComponent<ButcherController>();
  }
  private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            ScoreManager.mg.score += 500f;
            Destroy(this.gameObject);
        }
    }
  private void Update()
  {
    if (!butcher.canMove) 
    {
      this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
      this.GetComponent<Rigidbody2D>().gravityScale = 0f;
    }
  }
}
