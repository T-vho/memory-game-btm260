using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;


public class MenuBehavior : MonoBehaviour{
    public void triggerMenuBehavior(int i){
        switch(i) {
            default:
            case(0):
                SceneManager.LoadScene ("level");
                break;
            case(1):
                Application.Quit ();
                break;
        }
    }
}
