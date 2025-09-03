using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RootThreeSevenInversionButtonPrefabScript : MonoBehaviour
{

    public RootThreeSevenInversions thisR37Inversion;
    public Inversions inversion;
    public ChordController chordController;
    public UIController uIController;
    public RootThreeSevenController rootThreeSevenController;

    public TextMeshProUGUI buttonText;
    public TextMeshProUGUI inversionName;
    public TextMeshProUGUI inversionNotes;

    public Button button;

    public void ClickedOn()
    {
        chordController.currentInversion = inversion;
        uIController.ShowChordKeys(chordController.currentMasterChord, rootThreeSevenController.RootThreeSevenChord(chordController.currentChord));
               
         
        

        uIController.SetChordInversionText();
        uIController.SetChordText();


    }
}
