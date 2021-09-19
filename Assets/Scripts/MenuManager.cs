using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    public void gantiscene(string scene){
        SceneManager.LoadScene(scene);
    }

    public void exitgame(){
        Application.Quit();

    }
    
}
