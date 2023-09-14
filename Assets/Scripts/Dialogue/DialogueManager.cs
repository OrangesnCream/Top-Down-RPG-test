using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;
public class DialogueManager : MonoBehaviour {
    MouseInput submitButton;
    private static DialogueManager instance;
    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;
    private TextMeshProUGUI[] choicesText;
    private Story currentStory;
    public bool dialogueIsPlaying { get; private set; }
    private void Awake() {
        submitButton = new MouseInput();
        if (instance != null) {
            Debug.LogWarning("More than one dialogue manager in the scene");
        }
        instance = this;
    }
    private void OnEnable() {
        submitButton.Enable();
    }
    private void OnDisable() {
        submitButton.Disable();
    }
    public static DialogueManager GetInstance() {
        return instance;
    }
    private void SubmitPressed() {
        if (currentStory.currentChoices.Count == 0) {
            ContinueStory();
        }

    }
    private void Start() {
        submitButton.Text.Submit.performed += _ => SubmitPressed();
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        choicesText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach(GameObject choice in choices) {
            choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++;
        }
    }
    private void Update() {
        //return if dialogue isn't playing
        if (!dialogueIsPlaying) {
            return;
        }
        /*if (SubmitPressed()) {
            ContinueStory();
        }*/


    }
    public void EnterDialogueMode(TextAsset inkJSON) {
        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);
        ContinueStory();
    }
    private void ExitDialogueMode() {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text = "";
    }
    private void ContinueStory() {
        if (currentStory.canContinue) {
            dialogueText.text = currentStory.Continue();
            DisplayChoices();
        }
        else {
            ExitDialogueMode();
        }
    }
    private void DisplayChoices() {
        List<Choice> currentChoices = currentStory.currentChoices;
        if (currentChoices.Count > choices.Length) {
            Debug.LogError("More choices were given than the UI can support. Number of choices given:" + currentChoices.Count);
        }
        int index = 0;
        foreach(Choice choice in currentChoices) {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }
        for (int i = index; i < choices.Length; i++) {
            choices[i].gameObject.SetActive(false);
        }
        StartCoroutine(SelectFirstChoice());
    }
    private IEnumerator SelectFirstChoice() {
        EventSystem.current.SetSelectedGameObject(null);

        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
    }
    public void MakeChoice(int choiceIndex) {
        currentStory.ChooseChoiceIndex(choiceIndex);
        ContinueStory();

    }
}
