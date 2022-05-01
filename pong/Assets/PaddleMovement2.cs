using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement2 : MonoBehaviour
{
    private Transform transform;
    // Start is called before the first frame update
    [SerializeField] private float movementSpeed = .1f;
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + movementSpeed,
                transform.position.z);
        }
        else if (Input.GetKey("down"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - movementSpeed,
                transform.position.z);
        }
            
    }
}
