using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class tutorial : MonoBehaviour
{
    float time = 0;
    public float timeToDestroy = 10;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > timeToDestroy)
        {
           Destroy(gameObject);
        }


    }
}
