
using Assets.Scripts.David;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public ModelsManager modelsManager;

    [Tooltip("Model to activate")]
    public GameObject Model;

    public string Title;

    [HideInInspector]
    public bool IsActive;

    public void OnClick()
    {

        if (modelsManager.activeButton != null)
        {
            modelsManager.activeButton.IsActive = false;
            modelsManager.activeButton.GetComponent<OnEyeScript>().Unfocus();
        }

        modelsManager.StopGlobe();
        modelsManager.SetModel(Model);

        IsActive = true;
        modelsManager.activeButton = this;
    }

    public void Exit()
    {
        modelsManager.ContinueGlobe();
        modelsManager.DeleteModel();

        if (modelsManager.activeButton != null)
        {
            
            IsActive = false;
            modelsManager.activeButton.GetComponent<OnEyeScript>().Unfocus();

            modelsManager.activeButton = null;
        }
    }

}
