using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GrillMovement : MonoBehaviour
{
  public float pushForce = 5f;
  
  public float accelerometerX;
  public Rigidbody2D rb;
  
  private void Update()
  {
    accelerometerX = Input.acceleration.x;
    
  }
  private void FixedUpdate()
  {
    if (accelerometerX <= 0f)
    {
      rb.AddForce(new Vector2(accelerometerX * pushForce, 0f));
    }
    else if (accelerometerX >= 0f) 
    {
      rb.AddForce(new Vector2(accelerometerX * pushForce, 0f));
    }
  }
}
