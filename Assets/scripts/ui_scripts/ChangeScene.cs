using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class ChangeScene : MonoBehaviour
{

    public void ChangeToScene (int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void SceneBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
