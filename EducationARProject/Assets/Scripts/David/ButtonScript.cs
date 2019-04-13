
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public ModelsManager modelsManager;

    [Tooltip("Model to activate")]
    public GameObject Model;


    public void OnClick()
    {
        modelsManager.StopGlobe();
        modelsManager.SetModel(Model);
    }

}
