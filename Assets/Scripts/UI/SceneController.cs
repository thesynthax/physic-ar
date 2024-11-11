using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;


public class SceneController : MonoBehaviour
{
   public void Levels()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
