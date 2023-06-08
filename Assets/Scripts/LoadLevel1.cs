using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel1 : MonoBehaviour
{
   public void LoadObstacle1(){
    SceneManager.LoadScene("Level-1-1");
   }

   public void LoadObstacle2(){
    SceneManager.LoadScene("Level-1-2");
   }
}
