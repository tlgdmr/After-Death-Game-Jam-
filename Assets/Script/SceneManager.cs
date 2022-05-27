using UnityEngine;


public class SceneManager : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.collider.tag)
        {
            case "Finish":
                NextScene();
                break;
            case "Wall":
                ReloadScene();
                break;
            default:
                break;
        }
    }

    private void Update()
    {
        CheckPlayerPosition();
    }

    void CheckPlayerPosition()
    {
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 3)
        {
            if (transform.position.y < -60)
            {
                ReloadScene();
            }
        }
        else
        {
            if (transform.position.y < -5)
            {
                ReloadScene();
            }
        }
    }

    void NextScene()
    {
        int currentScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        int nextScene = currentScene + 1;
        if (nextScene == UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings)
        {
            nextScene = 1;
        }
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextScene);
    }

    void ReloadScene()
    {

        int currentScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        UnityEngine.SceneManagement.SceneManager.LoadScene(currentScene);
    }
}
