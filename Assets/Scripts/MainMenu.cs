using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public GameObject active;
    public int whatscenetoload;
  void Update()
    {
        if (active.active)
        {
            whatscenetoload = Random.Range(1, 3);
            SceneManager.LoadScene(whatscenetoload);
        }
    }
 


}
