using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class KeySocketInteraction : MonoBehaviour
{
    public XRSocketInteractor socketInteractor; // Reference to the socket interactor
    public bool keyInPlace = false; // This will become true when the key is in place

    private void OnEnable()
    {
        // Add listener for when an object is snapped into the socket
        socketInteractor.selectEntered.AddListener(OnSelectEntered);
        socketInteractor.selectExited.AddListener(OnSelectExited); 
    }

    private void OnDisable()
    {
        // Remove listener when this object is disabled or destroyed
        socketInteractor.selectEntered.RemoveListener(OnSelectEntered);
        socketInteractor.selectExited.RemoveListener(OnSelectExited);
    }

    // This method is called when an object is placed in the socket
    private void OnSelectEntered(SelectEnterEventArgs args)
    {
        keyInPlace = true; // Set the keyInPlace flag to true
        Debug.Log("Key has been placed in the socket!");
    }

    // This method is called when an object is removed from the socket
    private void OnSelectExited(SelectExitEventArgs args)
    {
        keyInPlace = false; // Set the keyInPlace flag to false
        Debug.Log("Key has been removed from the socket!");
    }
}
