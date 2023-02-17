using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///
using UnityEngine.SceneManagement;

public class NextLvL : MonoBehaviour
{
    public string nextlvl;
    GameObject fsl;
    FinishLvL fl;
    // Start is called before the first frame update
    void Start()
    {
        fsl = GameObject.Find("finish lvl");
        fl = fsl.GetComponent<FinishLvL>();
    }

    // Update is called once per frame
    void Update()
    {


        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && fl.isOpen == true)
        {
            SceneManager.LoadScene(nextlvl);
        }
    }



}
