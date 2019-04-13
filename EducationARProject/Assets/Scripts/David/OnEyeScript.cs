using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;

namespace Assets.Scripts.David
{
    public class OnEyeScript : MonoBehaviour, IMixedRealityFocusHandler
    {

        public Animator Anim;

        void IMixedRealityFocusHandler.OnFocusEnter(FocusEventData eventData)
        {
            Debug.Log("Jopa");
            Anim.SetBool("focused" , true);
        }

        void IMixedRealityFocusHandler.OnFocusExit(FocusEventData eventData)
        {
            Debug.Log("Hui");
            Anim.SetBool("focused", false);
        }
    }
}
