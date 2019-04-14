
using UnityEngine;

public class ModelsManager : MonoBehaviour
{
    [Tooltip("Rotation object to edit")]
    public Rotation Rotation;

    [Tooltip("Place where to spawn model")]
    public Transform PositionAnchor;

    public GameObject InfoPanel;

    private GameObject activeModel;
    private GameObject activePanel;

    public void SetModel(GameObject model)
    {
        if (activeModel != null)
        {
            DeleteModel();
        }

        activeModel = Instantiate(model, PositionAnchor);

        activePanel = activeModel.GetComponent<ModelScript>().SetInfo(InfoPanel);

    }

    private void DeleteModel()
    {
        activeModel.SetActive(false);
        Destroy(activeModel);

        activePanel.SetActive(false);
        Destroy(activePanel);
    }

    public void StopGlobe()
    {
        Rotation.isRotationActive = false;
    }
}
