using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class ARPlacementIntaractabableBlocking : ARPlacementInteractable
{
    protected override bool CanStartManipulationForGesture(TapGesture gesture) {
        Debug.Log(gesture.targetObject);
        if(gesture.startPosition.IsPointerOverUIObject()){
            Debug.Log("Over UI2");
            return false;
        }
        
        return gesture.targetObject == null;
    }
}
