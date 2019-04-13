
using UnityEngine;

public class ModelsManager : MonoBehaviour
{
    [Tooltip("Rotation object to edit")]
    public Rotation Rotation;

    [Tooltip("Place where to spawn model")]
    public Transform PositionAnchor;

    private GameObject activeModel;

    public void SetModel(GameObject model)
    {
        if (activeModel != null)
        {
            DeleteModel();
        }

        activeModel = Instantiate(model, PositionAnchor);
        
    }

    private void DeleteModel()
    {
        activeModel.SetActive(false);
        Destroy(activeModel);
    }

    public void StopGlobe()
    {
        Rotation.isRotationActive = false;
    }
}
