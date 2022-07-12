using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelComplete : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("You FINISHED!");
            SceneManager.LoadScene(0);
        }
    }
}
