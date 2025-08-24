using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class UIController : MonoBehaviour
{
    //orange = ffbb40

    // the piano keys

    public ChordController chordController;

    public bool isOn;

    public Sprite orangeKey;
    public Sprite blackKey;

    public Image C1;
    public Image CSharpDFlat1;
    public Image D1;
    public Image DSharpEFlat1;
    public Image E1;
    public Image F1;
    public Image FSharpGFlat1;
    public Image G1;
    public Image GSharpAFlat1;
    public Image A1;
    public Image ASharpBFlat1;
    public Image B1;
    public Image C2;
    public Image CSharpDFlat2;
    public Image D2;
    public Image DSharpEFlat2;
    public Image E2;
    public Image F2;
    public Image FSharpGFlat2;
    public Image G2;
    public Image GSharpAFlat2;
    public Image A2;
    public Image ASharpBFlat2;
    public Image B2;

    public Color white;
    public Color orange;

    public Dictionary<MasterChord, Image> firstOctaveMasterChordDict = new Dictionary<MasterChord, Image>();

    public List<Image> ListOfKeyImages = new List<Image>();
    public List<Image> ListOfWhiteKeyImages = new List<Image>();
    public List<Image> ListOfBlackKeyImages = new List<Image>();
    public List<Image> ListOfFirstOctaveKeyImages = new List<Image>();

    //selecting the masterchord
    public GameObject chooseMasterChordPanel;
    public GameObject chooseMasterChordButtonParent;

    //selecting the chord type
    public GameObject chooseChordTypePanel;
    public GameObject chooseChordTypeButtonParent;

    public GameObject masterChordButtonPrefab;
    public GameObject chordTypeButtonPrefab;

    public TextMeshProUGUI chordName;

    private void Awake()
    {
        ListOfKeyImages.Add(C1);
        ListOfKeyImages.Add(CSharpDFlat1);
        ListOfKeyImages.Add(D1);
        ListOfKeyImages.Add(DSharpEFlat1);
        ListOfKeyImages.Add(E1);
        ListOfKeyImages.Add(F1);
        ListOfKeyImages.Add(FSharpGFlat1);
        ListOfKeyImages.Add(G1);
        ListOfKeyImages.Add(GSharpAFlat1);
        ListOfKeyImages.Add(A1);
        ListOfKeyImages.Add(ASharpBFlat1);
        ListOfKeyImages.Add(B1);
        ListOfKeyImages.Add(C2);
        ListOfKeyImages.Add(CSharpDFlat2);
        ListOfKeyImages.Add(D2);
        ListOfKeyImages.Add(DSharpEFlat2);
        ListOfKeyImages.Add(E2);
        ListOfKeyImages.Add(F2);
        ListOfKeyImages.Add(FSharpGFlat2);
        ListOfKeyImages.Add(G2);
        ListOfKeyImages.Add(GSharpAFlat2);
        ListOfKeyImages.Add(A2);
        ListOfKeyImages.Add(ASharpBFlat2);
        ListOfKeyImages.Add(B2);

        ListOfWhiteKeyImages.Add(C1);
        ListOfBlackKeyImages.Add(CSharpDFlat1);
        ListOfWhiteKeyImages.Add(D1);
        ListOfBlackKeyImages.Add(DSharpEFlat1);
        ListOfWhiteKeyImages.Add(E1);
        ListOfWhiteKeyImages.Add(F1);
        ListOfBlackKeyImages.Add(FSharpGFlat1);
        ListOfWhiteKeyImages.Add(G1);
        ListOfBlackKeyImages.Add(GSharpAFlat1);
        ListOfWhiteKeyImages.Add(A1);
        ListOfBlackKeyImages.Add(ASharpBFlat1);
        ListOfWhiteKeyImages.Add(B1);
        ListOfWhiteKeyImages.Add(C2);
        ListOfBlackKeyImages.Add(CSharpDFlat2);
        ListOfWhiteKeyImages.Add(D2);
        ListOfBlackKeyImages.Add(DSharpEFlat2);
        ListOfWhiteKeyImages.Add(E2);
        ListOfWhiteKeyImages.Add(F2);
        ListOfBlackKeyImages.Add(FSharpGFlat2);
        ListOfWhiteKeyImages.Add(G2);
        ListOfBlackKeyImages.Add(GSharpAFlat2);
        ListOfWhiteKeyImages.Add(A2);
        ListOfBlackKeyImages.Add(ASharpBFlat2);
        ListOfWhiteKeyImages.Add(B2);

        ListOfFirstOctaveKeyImages.Add(C1);
        ListOfFirstOctaveKeyImages.Add(CSharpDFlat1);
        ListOfFirstOctaveKeyImages.Add(D1);
        ListOfFirstOctaveKeyImages.Add(DSharpEFlat1);
        ListOfFirstOctaveKeyImages.Add(E1);
        ListOfFirstOctaveKeyImages.Add(F1);
        ListOfFirstOctaveKeyImages.Add(FSharpGFlat1);
        ListOfFirstOctaveKeyImages.Add(G1);
        ListOfFirstOctaveKeyImages.Add(GSharpAFlat1);
        ListOfFirstOctaveKeyImages.Add(A1);
        ListOfFirstOctaveKeyImages.Add(ASharpBFlat1);
        ListOfFirstOctaveKeyImages.Add(B1);

        firstOctaveMasterChordDict.Add(MasterChord.C, C1);
        firstOctaveMasterChordDict.Add(MasterChord.CSharp, CSharpDFlat1);
        firstOctaveMasterChordDict.Add(MasterChord.DFlat, CSharpDFlat1);
        firstOctaveMasterChordDict.Add(MasterChord.D, D1);
        firstOctaveMasterChordDict.Add(MasterChord.DSharp, DSharpEFlat1);
        firstOctaveMasterChordDict.Add(MasterChord.EFlat, DSharpEFlat1);
        firstOctaveMasterChordDict.Add(MasterChord.E, E1);
        firstOctaveMasterChordDict.Add(MasterChord.F, F1);
        firstOctaveMasterChordDict.Add(MasterChord.FSharp, FSharpGFlat1);
        firstOctaveMasterChordDict.Add(MasterChord.GFlat, FSharpGFlat1);
        firstOctaveMasterChordDict.Add(MasterChord.G, G1);
        firstOctaveMasterChordDict.Add(MasterChord.GSharp, GSharpAFlat1);
        firstOctaveMasterChordDict.Add(MasterChord.AFlat, GSharpAFlat1);
        firstOctaveMasterChordDict.Add(MasterChord.A, A1);
        firstOctaveMasterChordDict.Add(MasterChord.ASharp, ASharpBFlat1);
        firstOctaveMasterChordDict.Add(MasterChord.BFlat, ASharpBFlat1);
        firstOctaveMasterChordDict.Add(MasterChord.B, B1);


        ResetKeyColor();

    }

    private void Start()
    {
        ResetKeyColor();
        SetupChooseMasterChordPanel();
    }

    public void ResetKeyColor()
    {
        foreach (Image key in ListOfKeyImages)
        {
            if(ListOfWhiteKeyImages.Contains(key))
            {
                key.color = white;
            }

            if (ListOfBlackKeyImages.Contains(key))
            {
                key.sprite = blackKey;
            }
        }

        isOn = false;
    }

    public void SetKeyColour(Image key)
    {
       
        if (ListOfWhiteKeyImages.Contains(key))
        {
            key.color = orange;
        }

        if (ListOfBlackKeyImages.Contains(key))
        {
            key.sprite = orangeKey;
        }

        isOn = true;


    }

    //this is the function that sets the keys - just all of htem for now
    public void ShowChordKeys(MasterChord masterChord, Chord chord)
    {
        ResetKeyColor();


        Image root = firstOctaveMasterChordDict[masterChord];

        int offset = ListOfKeyImages.IndexOf(root);

       // Debug.Log("offset " + offset);

        List<int> notes = chordController.CalculateNotes(masterChord, chord);

        for (int i = 0; i < notes.Count; i++)
        {
            SetKeyColour(ListOfKeyImages[notes[i] + offset]);
        }
    }


    public void ShowChordButton()
    {
      

        ShowChordKeys(chordController.currentMasterChord, chordController.currentChord);
        SetChordText();
    }

    public void SetupChooseMasterChordPanel()
    {
        chooseMasterChordPanel.SetActive(true);

        foreach (MasterChord masterChord in Enum.GetValues(typeof(MasterChord)))
        {
            GameObject buttonGO = Instantiate(masterChordButtonPrefab, chooseMasterChordButtonParent.transform);

            
            MasterChordButtonScript script = buttonGO.GetComponent<MasterChordButtonScript>();
            
            script.thisMasterChord = masterChord;
            script.chordController = chordController;
            script.uIController = this;
            script.buttonText.text = chordController.masterChordNameDict[masterChord];

            
            script.button.onClick.AddListener(script.MasterChordButton);
            
        }

      
    }

    public void SetChordText()
    {
        chordName.text = chordController.masterChordNameDict[chordController.currentMasterChord].ToString() + chordController.chordTypeNameDict[chordController.currentChord.chordType].ToString(); 
    }

    public void SetupChooseChordTypePanel()
    {
        
        chooseChordTypePanel.SetActive(true);
        ClearButtons(chooseChordTypeButtonParent.transform);


        foreach (ChordType chordType in Enum.GetValues(typeof(ChordType)))
        {
            GameObject buttonGO = Instantiate(chordTypeButtonPrefab, chooseChordTypeButtonParent.transform);


            ChordTypeButtonScript script = buttonGO.GetComponent<ChordTypeButtonScript>();
            script.thisChordType = chordType;
            script.chordController = chordController;
            script.uIController = this;
            script.buttonText.text = chordController.masterChordNameDict[chordController.currentMasterChord] + chordController.chordTypeNameDict[chordType];
            script.button.onClick.AddListener(script.ChordTypeButton);

        }

        //for fixing it
        HighlightErrorOnes();
    }

    public void ClearButtons(Transform parent)
    {
        foreach (Transform child in parent)
        {
            Destroy(child.gameObject);
        }
      
    }


    public void PianoPanelBackButton()
    {
        ClearButtons(chooseChordTypeButtonParent.transform);
        
        chooseChordTypePanel.SetActive(true);
        SetupChooseChordTypePanel();
    }

    public void ChooseChordTypePanelBackButton()
    {
        chooseMasterChordPanel.SetActive(true);
    }

    //so i can find the ones that need a different setyp
    public void HighlightErrorOnes()
    {
       // foreach (KeyValuePair<ChordType, Chord> chord in chordController.chordTypeDict)
        foreach (Transform child in chooseChordTypeButtonParent.transform)
        {

            ChordTypeButtonScript chordTypeButtonScript = child.GetComponent<ChordTypeButtonScript>();


            Image root = firstOctaveMasterChordDict[chordController.currentMasterChord];

            int offset = ListOfKeyImages.IndexOf(root);



            List<int> notes = chordController.CalculateNotes(chordController.currentMasterChord, chordController.chordTypeDict[chordTypeButtonScript.thisChordType]);

           
            if ((notes[notes.Count-1] + offset) >= 24)
            {
                chordTypeButtonScript.button.image.color = Color.red;

                //for now
                chordTypeButtonScript.button.interactable = false;

            }
        }
    }

}

