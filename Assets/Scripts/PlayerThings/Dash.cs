using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    private bool candash = true;
    private bool isDashing;
    public float dashingPower = 24f;
    public float dashingTime = 0.2f;
    public float dashingCooldawn = 1f;
    float direcion;
    // Start is called before the first frame update
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            direcion = 1;
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            direcion = -1;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) && candash)
        {
            StartCoroutine(Dashs());
        }
    }

    private IEnumerator Dashs()
    {
        candash = false;
        isDashing = true;
        float ogGravity = rb.gravityScale;
        rb.gravityScale = 0;
        rb.velocity = new Vector2(direcion * dashingPower,0);
        yield return new WaitForSeconds(dashingTime);
        rb.gravityScale = ogGravity;
        isDashing = false;
        yield return new WaitForSeconds(dashingCooldawn);
        candash = true;
    }
}
