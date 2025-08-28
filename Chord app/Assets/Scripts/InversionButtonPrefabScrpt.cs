using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InversionButtonPrefabScrpt : MonoBehaviour
{
    public Inversions thisInversion;
    public ChordController chordController;
    public UIController uIController;
    public void ClickedOn()
    {
        chordController.currentInversion = thisInversion;
        uIController.ShowChordKeys(chordController.currentMasterChord, chordController.currentChord);
        uIController.SetChordInversionText();
    }
}
