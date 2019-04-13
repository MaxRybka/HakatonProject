using UnityEngine;

public class OnEyeScript : MonoBehaviour
{
    [Tooltip("Rotation object to edit")]
    public Rotation rotation;

    public GameObject placeOfInterest;
    public GameObject pointer;



    public void OnEyeFocusDwell()
    {
        Debug.Log("Jopa");
    }
}
