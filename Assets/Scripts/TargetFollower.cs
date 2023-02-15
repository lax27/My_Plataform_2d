using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFollower : MonoBehaviour
{
    public Transform target;
    public float speed;
    public Vector3 offset;
    public float minDistance;

    
    private void Update()
    {
        if(Input.GetAxis("Horizontal") < 0)
        {
            offset.x = -6;
        }
        else if(Input.GetAxis("Horizontal") > 0)
        {
            offset.x = 6;
        }
    }
    void LateUpdate()
    {
        if (Vector2.Distance(transform.position,target.position + offset) > minDistance)
        {
            transform.position = Vector3.Lerp(transform.position, target.position + offset, speed * Time.deltaTime);
        }
        

    }
}
