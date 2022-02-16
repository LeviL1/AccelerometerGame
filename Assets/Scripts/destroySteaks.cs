using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroySteaks : MonoBehaviour
{
  public ButcherController butcher;
  public Animator anim;
  public int activeGrills = 3;
  public GameObject grill1;
  public GameObject grill2;
  public float scoreWhenGrillLost;
  
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.CompareTag("enemy") && activeGrills > 0) 
    {

      
      
      butcher.canMove = false;
      butcher.canDropSteak = false;
      Destroy(collision.gameObject);
      StartCoroutine(MoveTriggerVolume());
      
    }
  }
  private void Update()
  {
    
    if (activeGrills == 2) 
    {
      grill1.SetActive(false);
      
    }
    if (activeGrills == 1) 
    {
      grill2.SetActive(false);
    }
    if (ScoreManager.mg.score - scoreWhenGrillLost >= 2000) 
    {
      scoreWhenGrillLost = 0f;
      if (activeGrills == 2)
      {
        activeGrills += 1;
        grill1.SetActive(true);

      }
      else if (activeGrills == 1) 
      {
        activeGrills += 1;
        grill2.SetActive(true);
      }
    }
    
  }
  IEnumerator MoveTriggerVolume() 
  {
    anim.Play("MoveTrigger");
    yield return new WaitForSeconds(2f);
    
    
    butcher.canMove = true;
    butcher.canDropSteak = true;
  }
}
