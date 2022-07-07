using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
   [SerializeField] float loadDelay = 0.5f;
   void OnTriggerEnter2D(Collider2D other)
   {
      if(other.gameObject.tag == "Ground")
      {
         Debug.Log("Player has crashed!");
         Invoke("ReloadScene", loadDelay);
      }
   }
   void ReloadScene()
   {
      SceneManager.LoadScene(0);
   }
}
