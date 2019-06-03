using UnityEngine;
using UnityEngine.UI;

public class ShowMessage : MonoBehaviour {


    //public Text GameOverText = null;
    //public Text WinText = null;
    public GameObject GameOverUI;
    public GameObject InGameUI;
    public GameObject EmptyBoxes;


    //public void GameOverMessage()
    //{
    //    GameOverText.text = "GAME OVER!";
    //    WinText.enabled = false;
    //}

    //public void WinMessage(GameObject Winner)
    //{
    //    WinText.text = Winner.tag + " WON!";
    //    GameOverText.enabled = false;
    //}

    public void ActivateUI()
    {
        GameOverUI.SetActive(true);
        InGameUI.SetActive(false);
        EmptyBoxes.SetActive(false);
    }
}
