using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour,IClicked
{
    private bool playerHasClicked = false;
    public void onUnClickAction() {
        playerHasClicked = false;
    }
    public void onClickAction() {
        if (DialogueManager.GetInstance().dialogueIsPlaying) {
            return;
        }
        //Debug.Log("A click has been registered");
        playerHasClicked = true;
    }
    private bool playerInRange;
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    private void Awake() {
        //Debug.Log("Trigger is awake");
        playerInRange = false;
        
    }
    private void OnTriggerEnter2D(Collider2D collider) {
       // Debug.Log("Trigger is awake");
        if (collider.gameObject.tag == "Player") {
            playerInRange = true;
        }
        //Debug.Log(playerInRange);

    }
    private void OnTriggerExit2D(Collider2D collider) {
       // Debug.Log("Trigger is awake");
        if (collider.gameObject.tag == "Player") {
            playerInRange = false;
        }
    }
    private void Update() {
        if (playerInRange &&  playerHasClicked &&!DialogueManager.GetInstance().dialogueIsPlaying ) {
            // Debug.Log("Dialogue start");
            DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
            playerHasClicked = false;
        }
        
    }
}
