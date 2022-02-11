using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButcherController : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private float pushForce;
    public bool inRoutine = false;
    public float multiplier;
    public float leftorRight;
    [SerializeField]
    private float lowerForceBound;
    [SerializeField]
    private float upperForceBound;
    private bool canMove = true;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject Steak;
    [SerializeField]
    private bool canDrop = false;
    [SerializeField]
    private float dropInterval = 1f ;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
       
    }
    private void Update()
    {
        if (!inRoutine && canMove) 
        {
            inRoutine = true;
            StartCoroutine(ButcherMovement());
        }
        if (!canDrop) 
        {
            canDrop = true;
            StartCoroutine(DropSteak());
        }
    }

    IEnumerator ButcherMovement() 
    {
        
        pushForce = Random.Range(lowerForceBound, upperForceBound);
        leftorRight = Random.Range(0, 2);
        
        if (leftorRight == 0)
        {
            multiplier = -1;
        }
        else { multiplier = 1; }

        rb.AddForce(new Vector2(pushForce * multiplier, 0f));
        yield return new WaitForSeconds(1f);
        inRoutine = false;
        
        
    }
    IEnumerator DropSteak() 
    {
        Instantiate(Steak, spawnPoint);
        yield return new WaitForSeconds(dropInterval);
        canDrop = false;
    }

}
