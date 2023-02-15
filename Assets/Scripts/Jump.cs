using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public int TopJump = 1;
    Rigidbody2D rb;
    GroundDetector gr;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gr = GetComponent<GroundDetector>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.instance.isPaused)

            if(gr.grounded == true)
            {
                TopJump = 1;
            }
            
       if (Input.GetButtonDown("Jump"))
       {
            //primer salto
        if(gr.grounded == true && TopJump != 0)
        {
                    rb.AddForce(Vector2.up * force);
        }
        //segundo salto
        else if (gr.grounded != true && TopJump != 0)
        {
                TopJump--;
                    rb.AddForce(Vector2.up * force * 0.7f);
        }
       else
       {

       }
        
       }
          
            
            
    }
}
