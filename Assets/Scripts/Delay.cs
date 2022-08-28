using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Delay : MonoBehaviour
{
    [SerializeField]
    private float delayScene = 3f;
    
    [SerializeField]
    private string nextScene;

    private float timeElapsed;

    private void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > delayScene)
        {
            SceneManager.LoadScene(nextScene);
        }
    }


}

//Reference: https://www.youtube.com/watch?v=Oe9BZVnoedE&t=185s