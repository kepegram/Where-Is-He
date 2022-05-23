using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryNextScene : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("CampFire", LoadSceneMode.Single);
    }
}
