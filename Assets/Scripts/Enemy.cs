using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Enemy : MonoBehaviour
{
    public float timeSleep;
    public Transform player;
    public float enemySpeed = 10f;

    GameObject p;
    GameObject gridTrap;
    GameObject pichos;
    TrapSS s;
    TrapSS s2;
    
    // Start is called before the first frame update
    void Start()
    {
        p = GameObject.Find("Personaje");
        pichos = GameObject.Find("pinchos");
        s = pichos.GetComponent<TrapSS>();
        gridTrap = GameObject.Find("traps");
        s2 = gridTrap.GetComponent<TrapSS>();
    }

    // Update is called once per frame
    void Update()
    {
        timeSleep += Time.deltaTime;
       
        if( timeSleep > 2)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, enemySpeed * Time.deltaTime);
        }
        
        if (s2.PlayerDead == true || s.PlayerDead == true)
        {
            transform.position = new Vector3(-5.95f, 4.4f, 0);
            timeSleep = 0;
            p.transform.position = new Vector3(-1.25f, 1.66f, 0);
            s.PlayerDead = false;
            s2.PlayerDead = false;
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            transform.position = new Vector3(-5.95f, 4.4f, 0);
            timeSleep = 0;
            p.transform.position = new Vector3(-1.25f, 1.66f, 0);
        }
    }



}
