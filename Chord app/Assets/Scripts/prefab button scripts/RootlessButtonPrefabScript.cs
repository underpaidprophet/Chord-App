using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RootlessButtonPrefabScript : MonoBehaviour
{
    public Inversions inversion;
    public RootlessVoicingType thisRootlessVoicingType;
    public ChordController chordController;
    public UIController uIController;
    public RootlessController rootlessController;



    public TextMeshProUGUI buttonText;
    public TextMeshProUGUI inversionName;
    public TextMeshProUGUI inversionNotes;

    public Button button;

    public void ClickedOn()
    {
        
        chordController.currentInversion = inversion;
        rootlessController.currentRootlessVoicingType = thisRootlessVoicingType;

        uIController.ShowChordKeys(chordController.currentMasterChord, rootlessController.RootlessChord(chordController.currentChord));




        uIController.SetChordInversionText();
        uIController.SetChordText();


    }

}
