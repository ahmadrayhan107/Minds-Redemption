using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{
   public void LoadStageScene(){
    SceneManager.LoadScene("StageMenu");
   }

   public void LoadNewStageScene(){
    SceneManager.LoadScene("UnlockLvl2");
   }
}
