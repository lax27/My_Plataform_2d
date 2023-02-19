using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcitvatePlataform : MonoBehaviour
{
    GameObject pl;
    LinearMovement ln;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        pl = GameObject.Find("plataform");
        ln = pl.gameObject.GetComponent<LinearMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            sr.flipX = true;
           ln.enabled = true;
        }
    }
}
