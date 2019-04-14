using UnityEngine;
using UnityEngine.UI;

public class ModelScript : MonoBehaviour
{

    public Transform InfoRoot;
    public TextAsset TextFile;


    public GameObject SetInfo(GameObject infoPanel)
    {
        GameObject panel = Instantiate(infoPanel, InfoRoot);

        panel.GetComponentInChildren<Text>().text = TextFile.text;

        return panel;
    }
}
