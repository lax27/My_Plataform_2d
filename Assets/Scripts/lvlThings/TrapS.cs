using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapS : MonoBehaviour
{
    
    public Vector3 InitialPos = new Vector3(0, 0, 0);
    GameObject mainCam;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == ("Player"))
        {
     
            mainCam.transform.position = new Vector3(0, 0 - 10);

            collision.gameObject.transform.position = InitialPos;
        }
    }
}
