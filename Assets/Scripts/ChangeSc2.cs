using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject active;
    public int whatscenetoload;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
            if (active.active)
            {
                whatscenetoload = Random.Range(1, 3);
                SceneManager.LoadScene(whatscenetoload);
            }
    }



}
