using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    private Transform transform;

    private BoxCollider2D _boxCollider2D;
    
    // Start is called before the first frame update
    [SerializeField] private float movementSpeed = 5f;

    [SerializeField] private string up = "up";
    [SerializeField] private string down = "down";

    [SerializeField] private LayerMask wallMask;
    void Start()
    {
        transform = GetComponent<Transform>();
        _boxCollider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 updatePos = new Vector3();

        RaycastHit2D hit = new RaycastHit2D();
        if (Input.GetKey(up))
        {
            
            updatePos.y = movementSpeed;
            
        }
        else if (Input.GetKey(down))
        {

            updatePos.y = -movementSpeed;
        }
        
        // Check for hits in y direction
        hit = Physics2D.BoxCast(_boxCollider2D.bounds.center, _boxCollider2D.size, 0, new Vector2(0, updatePos.y),
            Mathf.Abs(updatePos.y * Time.deltaTime), wallMask);
        
        if (hit.collider == null)
        {
            // Move the character y
            transform.Translate(0, updatePos.y * Time.deltaTime, 0);
        }
        else
        {
            Debug.Log(hit.collider.name);
        }
            
        
        

    }
    
    
}
