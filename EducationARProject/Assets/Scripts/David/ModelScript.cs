using UnityEngine;
using UnityEngine.UI;

public class ModelScript : MonoBehaviour
{

    public Transform InfoRoot;
    public TextAsset TextFile;


    public GameObject SetInfo(GameObject infoPanel)
    {
        infoPanel.transform.position = InfoRoot.position;

        infoPanel.GetComponentInChildren<Text>().text = TextFile.text;
        infoPanel.SetActive(true);
        return infoPanel;
    }
}
