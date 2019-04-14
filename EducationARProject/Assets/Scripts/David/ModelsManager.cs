
using UnityEngine;
using UnityEngine.UI;

public class ModelsManager : MonoBehaviour
{
    [Tooltip("Rotation object to edit")]
    public Rotation Rotation;

    [Tooltip("Place where to spawn model")]
    public Transform PositionAnchor;

    public GameObject InfoPanel;

    public Text Title;

    private GameObject activeModel;

    [HideInInspector]
    public ButtonScript activeButton;

    public void SetModel(GameObject model)
    {
        if (activeModel != null)
        {
            DeleteModel();
        }

        activeModel = Instantiate(model, PositionAnchor);

        activeModel.GetComponent<ModelScript>().SetInfo(InfoPanel);

    }

    public void SetTitle(string title)
    {
        Title.text = title;
    }

    public void DeleteModel()
    {
        activeModel.SetActive(false);
        Destroy(activeModel);

        InfoPanel.SetActive(false);
        
    }

    public void StopGlobe()
    {
        Rotation.isRotationActive = false;
    }

    public void ContinueGlobe()
    {
        Rotation.isRotationActive = true;
        
    }
}
