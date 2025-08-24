using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MasterChordButtonScript : MonoBehaviour
{
    public MasterChord thisMasterChord;
    public ChordController chordController;
    public UIController uIController;

    public TextMeshProUGUI buttonText;
    public Button button;

    public void MasterChordButton()
    {
        chordController.currentMasterChord = thisMasterChord;
        uIController.SetupChooseChordTypePanel();
        uIController.chooseMasterChordPanel.SetActive(false);
        
    }
}
