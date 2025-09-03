using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChordTypeButtonScript : MonoBehaviour
{
    public ChordType thisChordType;
    public ChordController chordController;
    public UIController uIController;

    public TextMeshProUGUI buttonText;
    public Button button;
    public Image buttonImage;

    public void ChordTypeButton()
    {
        chordController.currentChord = chordController.chordTypeDict[thisChordType];
        uIController.chooseChordTypePanel.SetActive(false);
        uIController.ShowChordButton();
    }
}
