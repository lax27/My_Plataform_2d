using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLvL : MonoBehaviour
{
    SpriteRenderer sr;
    GameObject puerta;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        puerta = GameObject.Find("puerta");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("Player"))
        {

            sr.flipX = true;
            Debug.Log("Pasar al siguiente nivel");
            Destroy(puerta);

        }
    }
}
