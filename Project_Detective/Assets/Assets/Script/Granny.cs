using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granny : MonoBehaviour, InteractableObject
{

    public Dialogue dialogue; // Reference to the Dialogue system
    public DialogueData dialogueData; // Unique dialogue data for this NPC

    public void Interact()
    {
        if (dialogue != null && dialogueData != null)
        {
            dialogue.dialogueData = dialogueData; // Assign this NPC's dialogue data
            dialogue.gameObject.SetActive(true); // Activate the dialogue GameObject
            dialogue.StartDialogue(); // Start the dialogue sequence
        }
        else
        {
            Debug.LogWarning("Dialogue or DialogueData not set for " + transform.name);
        }
    }
}
