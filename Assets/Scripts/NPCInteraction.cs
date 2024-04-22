using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime; // Import the Inkle runtime namespace

public class NPCInteraction : MonoBehaviour
{
    public TextAsset inkJSONAsset; // Assign your Inkle JSON file here
    private Story story;

    void Start()
    {
        // Create a new Story object with the JSON file
        story = new Story(inkJSONAsset.text);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if collided with an object tagged as "NPC"
        if (collision.gameObject.CompareTag("NPC"))
        {
            Debug.Log("colliding");
            // Start dialogue when F key is pressed
            if (Input.GetKeyDown(KeyCode.F))
            {
                StartInkleDialogue();
            }
        }
    }

    void StartInkleDialogue()
    {
        // Continue the Inkle story until it needs input from the player
        while (story.canContinue)
        {
            string text = story.Continue();
            // Do something with the text, like displaying it in a UI
            Debug.Log(text);
        }

        // Check if the story is awaiting a choice
        if (story.currentChoices.Count > 0)
        {
            // Handle player choices here
            // For simplicity, let's just choose the first option
            Choice choice = story.currentChoices[0];
            story.ChooseChoiceIndex(choice.index);
        }
    }
}
