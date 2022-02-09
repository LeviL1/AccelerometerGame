using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GrillMovement : MonoBehaviour
{
  public float pushForce = 5f;
  public InputField pushForceField;
  public float accelerometerX;
  public Rigidbody2D rb;
  private void Start()
  {
    pushForceField.text = pushForce.ToString() ;
  }
  private void Update()
  {
    accelerometerX = Input.acceleration.x;
    pushForce = float.Parse(pushForceField.text);
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
