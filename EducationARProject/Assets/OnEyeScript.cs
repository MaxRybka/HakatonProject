using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;

public class OnEyeScript : MonoBehaviour, IMixedRealityFocusHandler
{
    [Tooltip("Rotation object to edit")]
    public Rotation rotation;

    public GameObject placeOfInterest;
    public GameObject pointer;

    public Animator anim;

    

    void IMixedRealityFocusHandler.OnFocusEnter(FocusEventData eventData)
    {
        Debug.Log("Jopa");
        anim.SetBool("focused" , true);
    }

    void IMixedRealityFocusHandler.OnFocusExit(FocusEventData eventData)
    {
        Debug.Log("Hui");
        anim.SetBool("focused", false);
    }

    public void OnEyeFocusDwell()
    {
        Debug.Log("Jopa");
    }
}
