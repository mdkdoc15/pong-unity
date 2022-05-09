using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    private Transform transform;
    // Start is called before the first frame update
    [SerializeField] private float movementSpeed = .1f;

    [SerializeField] private string up = "up";
    [SerializeField] private string down = "down";
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 updatePos = new Vector3(transform.position.x, transform.position.y,
            transform.position.z);
        
        
        if (Input.GetKey(up))
        {

            updatePos.y += movementSpeed;
            
        }
        else if (Input.GetKey(down))
        {
            updatePos.y -= movementSpeed;
        }

        transform.position = updatePos;

    }
}
