using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//
using UnityEngine.SceneManagement;


public class LevelSelect : MonoBehaviour
{
    public void LVL0(){
        SceneManager.LoadScene("LVL0");
    }
    public void LVL1(){
        SceneManager.LoadScene("LVL1");
    }
    public void LVL2(){
        SceneManager.LoadScene("LVL2");
    }
    public void LVL3(){
        SceneManager.LoadScene("LVL3");
    }
    public void LVL4(){
        SceneManager.LoadScene("LVL4");
    }
    public void LVL5(){
        SceneManager.LoadScene("LVL5");
    }
}
