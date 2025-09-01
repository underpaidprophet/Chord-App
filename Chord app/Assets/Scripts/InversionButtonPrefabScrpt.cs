using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InversionButtonPrefabScrpt : MonoBehaviour
{
    public Inversions thisInversion;
    public ChordController chordController;
    public UIController uIController;

    public TextMeshProUGUI buttonText;
    public TextMeshProUGUI inversionName;

  
    public Button button;

    public void ClickedOn()
    {
        chordController.currentInversion = thisInversion;
        uIController.ShowChordKeys(chordController.currentMasterChord, chordController.currentChord);
        uIController.SetChordInversionText();
        uIController.chordName.text = buttonText.text;
   

    }
}
