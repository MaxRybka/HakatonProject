using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    [Tooltip("Rotation object to edit")]
    public Rotation rotation;

    public GameObject placeOfInterest;

    public void OnClick()
    {
        rotation.isRotationActive = false;



    }

}
