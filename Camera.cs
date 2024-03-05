using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
 public Transform target;

    public float smoothspeed = 0.125f
 
    public Vector3 offset; 

    void LateUpdate()
{
    Vector3 desiredPosition = transform position + offset;
    Vector3 smootherPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed)
    transform.position = smoothedPosition;

    transform.LookAt(target);
}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
