using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour {

	public void LoadGameScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadLastScene()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
