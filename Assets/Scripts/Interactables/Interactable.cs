using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    //Base class for different interactibles
    //message displayed to player when looking at an interactable object
    public string promptMessage;

    //this function will be called from our player script
    public void BaseInteract()
    {
        Interact();
    }

    protected virtual void Interact()
    {
        // no Code here; just a template function to be overridden by our subclasses
    }
}
