using UnityEngine;

public class OnClick : MonoBehaviour {

    public GameObject Camera;
    public Gameplay Script;
    public GameObject[] Cellss;

    void Awake()
    {
        Script = Camera.GetComponent<Gameplay>();    
    }

    void OnMouseDown()
    {
        Script.SpawnCross(gameObject);
    }

    //void CircleObjectSelect(GameObject SelectedObj)
    //{
    //    SelectedObj = Cellss[Random.Range(0, Cellss.Length)];
    //    if (SelectedObj == gameObject)
    //    {
    //        CircleObjectSelect(SelectedObj);
    //    }
    //}
}
