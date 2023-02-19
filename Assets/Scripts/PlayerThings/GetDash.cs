using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDash : MonoBehaviour
{
    GameObject dash;
    Collectkey k;

    GameObject player;
    Dash d;
    // Start is called before the first frame update
    void Start()
    {
        dash = GameObject.Find("Key_0");
       k = dash.GetComponent<Collectkey>();

        player = GameObject.Find("Personaje");
        d = player.GetComponent<Dash>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && k.getKey == true)
        {
            d.enabled = true;
            Destroy(gameObject);
        }
    }

}
