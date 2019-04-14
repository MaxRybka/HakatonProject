using System;
using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;

namespace Assets.Scripts.David
{
    public class OnEyeScript : MonoBehaviour, IMixedRealityFocusHandler
    {
        
        public Animator Anim;

        void IMixedRealityFocusHandler.OnFocusEnter(FocusEventData eventData)
        {
            Focus();
            GetComponent<ButtonScript>().modelsManager.SetTitle(GetComponent<ButtonScript>().Title);
        }

        void IMixedRealityFocusHandler.OnFocusExit(FocusEventData eventData)
        {
            if (!GetComponent<ButtonScript>().IsActive)
                Unfocus();

            GetComponent<ButtonScript>().modelsManager.SetTitle(String.Empty);
        }

        public void Focus()
        {

            Anim.SetBool("focused", true);

        }

        public void Unfocus()
        {
            
            Anim.SetBool("focused", false);

        }
    }
}
