using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DoorWay : MonoBehaviour {

    public string level; 
        
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag.ToString() == "Player")
        {
            SceneManager.LoadScene(level);
        }  
    }      
}
