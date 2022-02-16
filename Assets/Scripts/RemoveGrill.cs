using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveGrill : MonoBehaviour
{
  public destroySteaks ds;

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.CompareTag("enemy")) 
    {
      ds.activeGrills -= 1;
      ds.scoreWhenGrillLost = ScoreManager.mg.score;
    }
  }
}
