using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;


public class UIController : MonoBehaviour
{
    public FStartingKeyboardController fStartingKeyboardController;
    public InversionController inversionController;
    public RootThreeSevenController rootThreeSevenController;

    //orange = ffbb40
   //   purple =  c5b0cd

    // the piano keys

    //regular location
    public Vector2 regularKeybaordLocation = new Vector2(-155, 79);
    public Vector3 regularKeybaordSize = new Vector3(0.5f, 0.5f, 0.5f);

    //extra 5 location
    public Vector2 extra5KeybaordLocation = new Vector2(-160, 79);
    public Vector3 extra5KeybaordSize = new Vector3(0.4f, 0.4f, 0.4f);


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
    public Image C3;
    public Image CSharpDFlat3;
    public Image D3;
    public Image DSharpEFlat3;
    public Image E3;

    public TextMeshProUGUI C1Text;
    public TextMeshProUGUI CSharpDFlat1Text;
    public TextMeshProUGUI D1Text;
    public TextMeshProUGUI DSharpEFlat1Text;
    public TextMeshProUGUI E1Text;
    public TextMeshProUGUI F1Text;
    public TextMeshProUGUI FSharpGFlat1Text;
    public TextMeshProUGUI G1Text;
    public TextMeshProUGUI GSharpAFlat1Text;
    public TextMeshProUGUI A1Text;
    public TextMeshProUGUI ASharpBFlat1Text;
    public TextMeshProUGUI B1Text;
    public TextMeshProUGUI C2Text;
    public TextMeshProUGUI CSharpDFlat2Text;
    public TextMeshProUGUI D2Text;
    public TextMeshProUGUI DSharpEFlat2Text;
    public TextMeshProUGUI E2Text;
    public TextMeshProUGUI F2Text;
    public TextMeshProUGUI FSharpGFlat2Text;
    public TextMeshProUGUI G2Text;
    public TextMeshProUGUI GSharpAFlat2Text;
    public TextMeshProUGUI A2Text;
    public TextMeshProUGUI ASharpBFlat2Text;
    public TextMeshProUGUI B2Text;
    public TextMeshProUGUI C3Text;
    public TextMeshProUGUI CSharpDFlat3Text;
    public TextMeshProUGUI D3Text;
    public TextMeshProUGUI DSharpEFlat3Text;
    public TextMeshProUGUI E3Text;

    public Color white;
    public Color orange;
    public Color purple;
    public Color black;
    public Color lightGreen;
    public Color darkGreen;

    public Color chosenKeyColor;


    public Dictionary<MasterChord, Image> firstOctaveMasterChordDict = new Dictionary<MasterChord, Image>();
    public Dictionary<Notes, Image> firstOctaveNotesDict = new Dictionary<Notes, Image>();

    public List<Image> ListOfKeyImages = new List<Image>();
    public List<Image> ListOfWhiteKeyImages = new List<Image>();
    public List<Image> ListOfBlackKeyImages = new List<Image>();
    public List<Image> ListOfFirstOctaveKeyImages = new List<Image>();
    public List<Image> ListOfExtra5KeyImages = new List<Image>();



    //selecting the masterchord
    public GameObject chooseMasterChordPanel;
    public GameObject chooseMasterChordButtonParent;

    //selecting the chord type
    public GameObject chooseChordTypePanel;
    public GameObject chooseChordTypeButtonParent;

    public GameObject masterChordButtonPrefab;
    public GameObject chordTypeButtonPrefab;

    public TextMeshProUGUI chordName;
    public TextMeshProUGUI chordInversionText;

    public GameObject keyboardLayout;
    public RectTransform keyboardLayoutRectTransform;

    public KeyboardLayout currentLayout;
    

    public Dictionary<Image, TextMeshProUGUI> keyTextDict = new Dictionary<Image, TextMeshProUGUI>();
    public Dictionary<Inversions, string> inversionsNameDict = new Dictionary<Inversions, string>();



    //  public List<GameObject> inversionButtons = new List<GameObject>();
    //  public GameObject rootPositionInversionButton;
    //  public GameObject firstInversionButton;
    //  public GameObject secondInversionButton;
    //  public GameObject thirdInversionButton;
    public GameObject inversionButtonPrefab;
    public GameObject inversionButtonParent;
  


    public TextMeshProUGUI noteNamesText;

    public ChordVariation currentChordVariation = ChordVariation.Intervals;

    public TextMeshProUGUI rootThreeSevenChordName;
    public TextMeshProUGUI rootThreeSevenText;
    public GameObject rootThreeSevenButtonParent;
    public GameObject rootThreeSevenButton;

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
        ListOfKeyImages.Add(C3);
        ListOfKeyImages.Add(CSharpDFlat3);
        ListOfKeyImages.Add(D3);
        ListOfKeyImages.Add(DSharpEFlat3);
        ListOfKeyImages.Add(E3);

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
        ListOfWhiteKeyImages.Add(C3);
        ListOfBlackKeyImages.Add(CSharpDFlat3);
        ListOfWhiteKeyImages.Add(D3);
        ListOfBlackKeyImages.Add(DSharpEFlat3);
        ListOfWhiteKeyImages.Add(E3);


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

        firstOctaveNotesDict.Add(Notes.C, C1);
        firstOctaveNotesDict.Add(Notes.CSharp, CSharpDFlat1);
        firstOctaveNotesDict.Add(Notes.CDoubleSharp, D1);
        firstOctaveNotesDict.Add(Notes.CFlat, B1);
        firstOctaveNotesDict.Add(Notes.CDoubleFlat, ASharpBFlat1);

        firstOctaveNotesDict.Add(Notes.DFlat, CSharpDFlat1);
        firstOctaveNotesDict.Add(Notes.D, D1);
        firstOctaveNotesDict.Add(Notes.DSharp, DSharpEFlat1);
        firstOctaveNotesDict.Add(Notes.DDoubleSharp, E1);
        firstOctaveNotesDict.Add(Notes.DDoubleFlat, C1);

        firstOctaveNotesDict.Add(Notes.EFlat, DSharpEFlat1);
        firstOctaveNotesDict.Add(Notes.E, E1);
        firstOctaveNotesDict.Add(Notes.ESharp, F1);
        firstOctaveNotesDict.Add(Notes.EDoubleSharp, FSharpGFlat1);
        firstOctaveNotesDict.Add(Notes.EDoubleFlat, D1);

        firstOctaveNotesDict.Add(Notes.F, F1);
        firstOctaveNotesDict.Add(Notes.FFlat, E1);
        firstOctaveNotesDict.Add(Notes.FSharp, FSharpGFlat1);
        firstOctaveNotesDict.Add(Notes.FDoubleSharp, G1);
        firstOctaveNotesDict.Add(Notes.FDoubleFlat, DSharpEFlat1);

        firstOctaveNotesDict.Add(Notes.GFlat, FSharpGFlat1);
        firstOctaveNotesDict.Add(Notes.G, G1);
        firstOctaveNotesDict.Add(Notes.GSharp, GSharpAFlat1);
        firstOctaveNotesDict.Add(Notes.GDoubleSharp, A1);
        firstOctaveNotesDict.Add(Notes.GDoubleFlat, F1);

        firstOctaveNotesDict.Add(Notes.AFlat, GSharpAFlat1);
        firstOctaveNotesDict.Add(Notes.A, A1);
        firstOctaveNotesDict.Add(Notes.ASharp, ASharpBFlat1);
        firstOctaveNotesDict.Add(Notes.ADoubleSharp, B1);
        firstOctaveNotesDict.Add(Notes.ADoubleFlat, G1);

        firstOctaveNotesDict.Add(Notes.BFlat, ASharpBFlat1);
        firstOctaveNotesDict.Add(Notes.B, B1);
        firstOctaveNotesDict.Add(Notes.BSharp, C2);
        firstOctaveNotesDict.Add(Notes.BDoubleFlat, A1);
        firstOctaveNotesDict.Add(Notes.BDoubleSharp, CSharpDFlat1);

        ListOfExtra5KeyImages.Add(C3);
        ListOfExtra5KeyImages.Add(CSharpDFlat3);
        ListOfExtra5KeyImages.Add(D3);
        ListOfExtra5KeyImages.Add(DSharpEFlat3);
        ListOfExtra5KeyImages.Add(E3);

         keyTextDict.Add(C1, C1Text);
    keyTextDict.Add(CSharpDFlat1, CSharpDFlat1Text);
    keyTextDict.Add(D1, D1Text);
    keyTextDict.Add(DSharpEFlat1, DSharpEFlat1Text);
    keyTextDict.Add(E1, E1Text);
    keyTextDict.Add(F1, F1Text);
    keyTextDict.Add(FSharpGFlat1, FSharpGFlat1Text);
    keyTextDict.Add(G1, G1Text);
    keyTextDict.Add(GSharpAFlat1, GSharpAFlat1Text);
    keyTextDict.Add(A1, A1Text);
    keyTextDict.Add(ASharpBFlat1, ASharpBFlat1Text);
    keyTextDict.Add(B1, B1Text);
    keyTextDict.Add(C2, C2Text);
    keyTextDict.Add(CSharpDFlat2, CSharpDFlat2Text);
    keyTextDict.Add(D2, D2Text);
    keyTextDict.Add(DSharpEFlat2, DSharpEFlat2Text);
    keyTextDict.Add(E2, E2Text);
    keyTextDict.Add(F2, F2Text);
    keyTextDict.Add(FSharpGFlat2, FSharpGFlat2Text);
    keyTextDict.Add(G2, G2Text);
    keyTextDict.Add(GSharpAFlat2, GSharpAFlat2Text);
    keyTextDict.Add(A2, A2Text);
    keyTextDict.Add(ASharpBFlat2, ASharpBFlat2Text);
    keyTextDict.Add(B2, B2Text);
    keyTextDict.Add(C3, C3Text);
    keyTextDict.Add(CSharpDFlat3, CSharpDFlat3Text);
    keyTextDict.Add(D3, D3Text);
    keyTextDict.Add(DSharpEFlat3, DSharpEFlat3Text);
    keyTextDict.Add(E3, E3Text);

    ResetKeyColor();

        inversionsNameDict.Add(Inversions.RootPosition, "Root position");
        inversionsNameDict.Add(Inversions.FirstInversion, "First Inversion");
        inversionsNameDict.Add(Inversions.SecondInversion, "Second Inversion");
        inversionsNameDict.Add(Inversions.ThirdInversion, "Third Inversion");


       
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
                key.color = black;
            }

            keyTextDict[key].text = "";
            
        }

        foreach (Image key in fStartingKeyboardController.listOfKeyImages)
        {
            if (fStartingKeyboardController.listOfWhiteKeyImages.Contains(key))
            {
                key.color = white;
            }

            if (fStartingKeyboardController.listOfBlackKeyImages.Contains(key))
            {
                key.color = black;
            }
            fStartingKeyboardController.keyTextDict[key].text = "";
        }

        isOn = false;
    }

    public void SetKeyColour(Image key)
    {

        List<Image> whiteKeys = new List<Image>();
        List<Image> blackKeys = new List<Image>();

        switch (currentLayout)
        {
            case KeyboardLayout.regular:
                whiteKeys = ListOfWhiteKeyImages;
                blackKeys = ListOfBlackKeyImages;
                break;
            case KeyboardLayout.extra5Keys:
                whiteKeys = ListOfWhiteKeyImages;
                blackKeys = ListOfBlackKeyImages;
                break;
            case KeyboardLayout.fStartingKEyboard:
                whiteKeys = fStartingKeyboardController.listOfWhiteKeyImages;
                blackKeys = fStartingKeyboardController.listOfBlackKeyImages;
                break;
            default:
                break;
        }



      //  if (ListOfWhiteKeyImages.Contains(key))
        if (whiteKeys.Contains(key))
        {
           // key.color = orange;
            key.color = chosenKeyColor;
          
        }

      //  if (ListOfBlackKeyImages.Contains(key))
        if (blackKeys.Contains(key))
        {
            key.color = chosenKeyColor;

        }

        isOn = true;


    }

    //this is the function that sets the keys 
    public void ShowChordKeys(MasterChord masterChord, Chord chord)
    {
        ResetKeyColor();

        SetKeyboardLayoutSize(masterChord, chord);


        List<Image> keyImageList = new List<Image>();
        Dictionary<MasterChord, Image> firstOctaveChordDict = new Dictionary<MasterChord, Image>();
        Dictionary<Image, TextMeshProUGUI> keyTextDictToUse = new Dictionary<Image, TextMeshProUGUI>(); 

        switch (currentLayout)
        {
            case KeyboardLayout.regular:
                keyImageList = ListOfKeyImages;
                firstOctaveChordDict = firstOctaveMasterChordDict;
                keyTextDictToUse = keyTextDict;
                break;

            case KeyboardLayout.extra5Keys:
                keyImageList = ListOfKeyImages;
                firstOctaveChordDict = firstOctaveMasterChordDict;
                keyTextDictToUse = keyTextDict;
                break;

            case KeyboardLayout.fStartingKEyboard:
                keyImageList = fStartingKeyboardController.listOfKeyImages;
                firstOctaveChordDict = fStartingKeyboardController.firstOctaveMasterChordDict;
                keyTextDictToUse = fStartingKeyboardController.keyTextDict;
                break;
        
        }



        List<int> notes = chordController.CalculatIntervalss(masterChord, chord);



        List<Intervals> intervals = new List<Intervals>(chordController.currentChord.intervalsList);
      
        List<Intervals> tempIntervals = new List<Intervals>(chordController.currentChord.intervalsList);

        /*
        if(chordController.rootThreeSeven)
        {
         
            foreach (Intervals interval in intervals)
            {
                if(chordController.intervalIntDict[interval] != 0 && chordController.intervalIntDict[interval] != 3 && chordController.intervalIntDict[interval] != 7)
                {
                    tempIntervals.Remove(interval);
                }
            }
        }
        */

        intervals = tempIntervals;

        List<Notes> notesInChord = chordController.SetChordNotes(chord, masterChord);

        List<Intervals> chordIntervalsList = new List<Intervals>();
        foreach (Intervals item in chord.intervalsList)
        {
            chordIntervalsList.Add(item);
        }
        
        /*
        if (chordController.rootThreeSeven)
        {
            chordIntervalsList = RootThreeSevenChord(chordIntervalsList);

        }
        */
        notesInChord = chordController.AdjustNotes(notesInChord, chordIntervalsList);
        chordController.notesInCurrentChord = notesInChord;

        

        switch (chordController.currentInversion)
        {
            case Inversions.RootPosition:
                notes = inversionController.RootPoositionSemitones(notes);
                break;
            case Inversions.FirstInversion:
               
                notes = inversionController.FirstInversionSemitones(notes);
            
                break;
            case Inversions.SecondInversion:
                notes = inversionController.SecondInversionSemitones(notes);
                break;
            case Inversions.ThirdInversion:
                notes = inversionController.ThirdInversionSemitones(notes);

                break;
            
        }

      notesInChord =  inversionController.InvertNotesList(notesInChord, chordController.currentInversion);

        Image noteRoot = firstOctaveNotesDict[notesInChord[0]];
        Image chordRoot = firstOctaveMasterChordDict[chordController.currentMasterChord];

      
        int offset = keyImageList.IndexOf(chordRoot);



        string noteNames = "";

        List<int> tempNotes = new List<int>(notes);
        tempNotes.Sort();
        int smallestInterval = tempNotes[0];

      
        for (int i = 0; i < notes.Count; i++)
        {
            int adjustedInterval = notes[i];

            //bring to the left
            if (smallestInterval + offset > 11)
            {
                adjustedInterval = notes[i] - 12;
               

            }
            
            SetKeyColour(keyImageList[adjustedInterval + offset]);

            //set the note text
          
        
            keyTextDictToUse[keyImageList[adjustedInterval + offset]].text = chordController.intervalNamesDict[intervals[i]];
           
          
        }


        foreach (Notes note in notesInChord)
        {
            noteNames = noteNames + chordController.noteNameDict[note] + " "; 
        }

        noteNamesText.text = noteNames;

        
       

    }


    public void ShowChordButton()
    {
        chordController.currentInversion = Inversions.RootPosition;
        SetChordInversionText();


      //  CheckRootSevenButton();
        ShowChordKeys(chordController.currentMasterChord, chordController.currentChord);
        SetChordText();
        
      
            inversionController.SetInversionButtons();
        

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

    public void SetChordInversionText()
    {
        chordInversionText.text = inversionsNameDict[chordController.currentInversion];
       
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

        //for fixing it (it works now)
       // HighlightErrorOnes();
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
        InversionsButton();

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



            List<int> notes = chordController.CalculatIntervalss(chordController.currentMasterChord, chordController.chordTypeDict[chordTypeButtonScript.thisChordType]);
           
           
            
            if ((notes[notes.Count-1] + offset) >= 29)
            {
                chordTypeButtonScript.button.image.color = Color.red;

                //for now
              //  chordTypeButtonScript.button.interactable = false;

            }
            else if ((notes[notes.Count - 1] + offset) >= 24 )
            {
                // chordTypeButtonScript.button.image.color = Color.blue;
                chordTypeButtonScript.button.interactable = true;
                //for now


            }
        }
    }

    public void SetKeyboardLayoutSize(MasterChord masterChord, Chord chord)
    {



        Image root = firstOctaveMasterChordDict[masterChord];

        int offset = ListOfKeyImages.IndexOf(root);



        List<int> notes = chordController.CalculatIntervalss(masterChord, chord);


        if ((notes[notes.Count - 1] + offset) >= 29)
        {
            SetupFKeyboardLayout();

        }
        else if ((notes[notes.Count - 1] + offset) >= 24)
        {
            SetupExtra5KeyboardLayout();

        }
        else
        {
            SetupRegularKeyboardLayout();
        }
    }

    public void SetupRegularKeyboardLayout()
    {
        currentLayout = KeyboardLayout.regular;

        fStartingKeyboardController.FKeyboardLayoutRectTransform.transform.gameObject.SetActive(false);
        keyboardLayout.SetActive(true);

        keyboardLayout.GetComponent<RectTransform>().localScale = regularKeybaordSize;
    //    keyboardLayout.transform.position = regularKeybaordLocation;
        foreach (Image image in ListOfExtra5KeyImages)
        {
            image.transform.gameObject.SetActive(false);
        }
    }
    public void SetupExtra5KeyboardLayout()
    {
        currentLayout = KeyboardLayout.extra5Keys;

        fStartingKeyboardController.FKeyboardLayoutRectTransform.transform.gameObject.SetActive(false);
        keyboardLayout.SetActive(true);

        keyboardLayoutRectTransform.localScale = extra5KeybaordSize;
        keyboardLayoutRectTransform.anchoredPosition = extra5KeybaordLocation;
        foreach (Image image in ListOfExtra5KeyImages)
        {
            image.transform.gameObject.SetActive(true);
        }
        
    }


    public void SetupFKeyboardLayout()
    {

        currentLayout = KeyboardLayout.fStartingKEyboard;
        fStartingKeyboardController.FKeyboardLayoutRectTransform.transform.gameObject.SetActive(true);
        keyboardLayout.SetActive(false);



    }


    public void QuitButton()
    {
        Application.Quit();
    }

    public void RootThreeSevenButton()
    {
        chordController.rootThreeSeven = true;
        currentChordVariation = ChordVariation.RootThreeSeven;
        ShowChordKeys(chordController.currentMasterChord, rootThreeSevenController.RootThreeSevenChord(chordController.currentChord));


        /*
        chordController.rootThreeSeven = !chordController.rootThreeSeven;
        ShowChordKeys(chordController.currentMasterChord, chordController.currentChord);

        if (chordController.rootThreeSeven)
        {
            inversionButtonParent.SetActive(false);
            rootThreeSevenButtonParent.SetActive(true);
            currentChordVariation = ChordVariation.RootThreeSeven;
            rootThreeSevenChordName.text = chordName.text;
            rootThreeSevenText.text = "Root 3 7\n" + noteNamesText.text;
            
        }
        if (!chordController.rootThreeSeven)
        {
            //change this later probably
            inversionButtonParent.SetActive(true);
            rootThreeSevenButtonParent.SetActive(false);
        }
        */
    }
    
    public void InversionsButton()
    {
        chordController.rootThreeSeven = false;
        rootThreeSevenButtonParent.SetActive(false);
        currentChordVariation = ChordVariation.Intervals;
        chordController.currentInversion = Inversions.RootPosition;
       
        inversionButtonParent.SetActive(true);
        ShowChordKeys(chordController.currentMasterChord, chordController.currentChord);

    }


 /*
    public void CheckRootSevenButton()
    {
        rootThreeSevenButton.SetActive(false);
        if (chordController.currentChord.intervalsList.Count == 4)
        {
            int count = 0;
            for (int i = 0; i < chordController.currentChord.intervalsList.Count; i++)
            {
                if (chordController.intervalIntDict[chordController.currentChord.intervalsList[i]] == 0
                    || chordController.intervalIntDict[chordController.currentChord.intervalsList[i]] == 3
                   || chordController.intervalIntDict[chordController.currentChord.intervalsList[i]] == 7)
                {
                    
                    count++;
                   
                }

               
            }
            
            if (count == 3)
            {
                rootThreeSevenButton.SetActive(true);
            }
        }
        else
        {
            rootThreeSevenButton.SetActive(false);
        }

        
    }
 */
}

public enum KeyboardLayout
{
    regular,
    extra5Keys,
    fStartingKEyboard
}

public enum ChordVariation
{
    Intervals,
    RootThreeSeven

}



