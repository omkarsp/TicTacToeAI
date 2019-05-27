using UnityEngine;
using UnityEngine.UI;

public class Gameplay : MonoBehaviour {

    public GameObject Circle, Cross;
    public GameObject[] Cells = new GameObject[9];
    public enum Cell { empty, circle, cross};//for multiplayer
    public Cell turn;//for multiplayer
    public string CircleTag = "circle";
    public string CrossTag = "cross";
    public int TurnCount = 0;
    public int CircleTurn = 0;
    public Text FinishText;
    public string WinnerTag = null;

    public void SpawnCross(GameObject obj)
    {
        if((obj.tag != CrossTag) && (obj.tag != CircleTag))
        {
            Instantiate(Cross, obj.transform.position, Quaternion.identity);
            obj.tag = CrossTag;
            TrackTags(obj);

            CircleTurn++;
            SpawnCircle();
        }
    }

    public void SpawnCircle()
    {
        if(CircleTurn < 5)
        {
            GameObject CircleCell = Cells[Random.Range(0, 8)];
            if ((CircleCell.tag != CrossTag) && (CircleCell.tag != CircleTag))
            {
                Instantiate(Circle, CircleCell.transform.position, Quaternion.identity);
                CircleCell.tag = CircleTag;
                TrackTags(CircleCell);
            }
            else
            {
                SpawnCircle();
            }
        }
    }

    public void TrackTags(GameObject ACell)
    {
        TurnCount++;

        if ((Cells[0].tag == Cells[1].tag) && (Cells[1].tag == Cells[2].tag))
        {
            FindObjectOfType<ShowMessage>().ActivateUI();
            //FindObjectOfType<SceneLoading>().LoadLastScene();
        }

        else if ((Cells[3].tag == Cells[4].tag) && (Cells[4].tag == Cells[5].tag))
        {
            FindObjectOfType<ShowMessage>().ActivateUI();
            //FindObjectOfType<SceneLoading>().LoadLastScene();
        }

        else if ((Cells[6].tag == Cells[7].tag) && (Cells[7].tag == Cells[8].tag))
        {
            FindObjectOfType<ShowMessage>().ActivateUI();
            //FindObjectOfType<SceneLoading>().LoadLastScene();
        }

        else if ((Cells[0].tag == Cells[3].tag) && (Cells[3].tag == Cells[6].tag))
        {
            FindObjectOfType<ShowMessage>().ActivateUI();
            //FindObjectOfType<SceneLoading>().LoadLastScene();
        }

        else if ((Cells[1].tag == Cells[4].tag) && (Cells[4].tag == Cells[7].tag))
        {
            FindObjectOfType<ShowMessage>().ActivateUI();
            //FindObjectOfType<SceneLoading>().LoadLastScene();
        }
    
        else if ((Cells[2].tag == Cells[5].tag) && (Cells[5].tag == Cells[8].tag))
        {
            FindObjectOfType<ShowMessage>().ActivateUI();
            //FindObjectOfType<SceneLoading>().LoadLastScene();
        }

        else if ((Cells[0].tag == Cells[4].tag) && (Cells[4].tag == Cells[8].tag))
        {
            FindObjectOfType<ShowMessage>().ActivateUI();
            //FindObjectOfType<SceneLoading>().LoadLastScene();
        }

        else if ((Cells[2].tag == Cells[4].tag) && (Cells[4].tag == Cells[6].tag))
        {
            FindObjectOfType<ShowMessage>().ActivateUI();
            //FindObjectOfType<SceneLoading>().LoadLastScene();
        }

        else if (TurnCount == 9)
        {
            //FindObjectOfType<SceneLoading>().LoadLastScene();
        }
    }

    public void FinalText()
    {
        if (Winnertag == "cross")
        {

        }
    }

    //public void BotPlay(GameObject BotCell)
    //{
    //    BotCell = Cells[Random.Range(0, 8)];
    //    if((BotCell.tag != CrossTag) && (BotCell.tag != CircleTag))
    //    {
    //        Instantiate(Circle, BotCell.transform.position, Quaternion.identity);
    //    }
    //    else
    //    {
    //        BotPlay(BotCell);
    //    }
    //}
}
