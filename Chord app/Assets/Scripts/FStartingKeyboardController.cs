using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FStartingKeyboardController : MonoBehaviour
{
    public Image F0;
    public Image FSharpGFlat0;
    public Image G0;
    public Image GSharpAFlat0;
    public Image A0;
    public Image ASharpBFlat0;
    public Image B0;
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

   
    public RectTransform FKeyboardLayoutRectTransform;


    public Dictionary<MasterChord, Image> firstOctaveMasterChordDict = new Dictionary<MasterChord, Image>();

    public List<Image> listOfKeyImages = new List<Image>();
    public List<Image> listOfWhiteKeyImages = new List<Image>();
    public List<Image> listOfBlackKeyImages = new List<Image>();
    public List<Image> listOfFirstOctaveKeyImages = new List<Image>();
    public List<Image> listOfExtra5KeyImages = new List<Image>();


    public TextMeshProUGUI F0Text;
    public TextMeshProUGUI FSharpGFlat0Text;
    public TextMeshProUGUI G0Text;
    public TextMeshProUGUI GSharpAFlat0Text;
    public TextMeshProUGUI A0Text;
    public TextMeshProUGUI ASharpBFlat0Text;
    public TextMeshProUGUI B0Text;
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

    public Dictionary<Image, TextMeshProUGUI> keyTextDict = new Dictionary<Image, TextMeshProUGUI>();

    private void Awake()
    {
        listOfFirstOctaveKeyImages.Add(F0);
    
    listOfFirstOctaveKeyImages.Add(FSharpGFlat0);
    listOfFirstOctaveKeyImages.Add(G0);
    listOfFirstOctaveKeyImages.Add(GSharpAFlat0);
    listOfFirstOctaveKeyImages.Add(A0);
    listOfFirstOctaveKeyImages.Add(ASharpBFlat0);
    listOfFirstOctaveKeyImages.Add(B0);
    listOfFirstOctaveKeyImages.Add(C1);
    listOfFirstOctaveKeyImages.Add(CSharpDFlat1);
    listOfFirstOctaveKeyImages.Add(D1);
    listOfFirstOctaveKeyImages.Add(DSharpEFlat1);
    listOfFirstOctaveKeyImages.Add(E1);

    listOfKeyImages.Add(F0);
    listOfKeyImages.Add(FSharpGFlat0);
    listOfKeyImages.Add(G0);
    listOfKeyImages.Add(GSharpAFlat0);
    listOfKeyImages.Add(A0);
    listOfKeyImages.Add(ASharpBFlat0);
    listOfKeyImages.Add(B0);
    listOfKeyImages.Add(C1);
    listOfKeyImages.Add(CSharpDFlat1);
    listOfKeyImages.Add(D1);
    listOfKeyImages.Add(DSharpEFlat1);
    listOfKeyImages.Add(E1);
    listOfKeyImages.Add(F1);
    listOfKeyImages.Add(FSharpGFlat1);
    listOfKeyImages.Add(G1);
    listOfKeyImages.Add(GSharpAFlat1);
    listOfKeyImages.Add(A1);
    listOfKeyImages.Add(ASharpBFlat1);
    listOfKeyImages.Add(B1);
    listOfKeyImages.Add(C2);
    listOfKeyImages.Add(CSharpDFlat2);
    listOfKeyImages.Add(D2);
    listOfKeyImages.Add(DSharpEFlat2);
    listOfKeyImages.Add(E2);
    listOfKeyImages.Add(F2);
    listOfKeyImages.Add(FSharpGFlat2);
    listOfKeyImages.Add(G2);
    listOfKeyImages.Add(GSharpAFlat2);
    listOfKeyImages.Add(A2);
    listOfKeyImages.Add(ASharpBFlat2);
    listOfKeyImages.Add(B2);

        listOfWhiteKeyImages.Add(F0);
        listOfBlackKeyImages.Add(FSharpGFlat0);
        listOfWhiteKeyImages.Add(G0);
        listOfBlackKeyImages.Add(GSharpAFlat0);
        listOfWhiteKeyImages.Add(A0);
        listOfBlackKeyImages.Add(ASharpBFlat0);
        listOfWhiteKeyImages.Add(B0);
        listOfWhiteKeyImages.Add(C1);
        listOfBlackKeyImages.Add(CSharpDFlat1);
        listOfWhiteKeyImages.Add(D1);
        listOfBlackKeyImages.Add(DSharpEFlat1);
        listOfWhiteKeyImages.Add(E1);
        listOfWhiteKeyImages.Add(F1);
        listOfBlackKeyImages.Add(FSharpGFlat1);
        listOfWhiteKeyImages.Add(G1);
        listOfBlackKeyImages.Add(GSharpAFlat1);
        listOfWhiteKeyImages.Add(A1);
        listOfBlackKeyImages.Add(ASharpBFlat1);
        listOfWhiteKeyImages.Add(B1);
        listOfWhiteKeyImages.Add(C2);
        listOfBlackKeyImages.Add(CSharpDFlat2);
        listOfWhiteKeyImages.Add(D2);
        listOfBlackKeyImages.Add(DSharpEFlat2);
        listOfWhiteKeyImages.Add(E2);
        listOfWhiteKeyImages.Add(F2);
        listOfBlackKeyImages.Add(FSharpGFlat2);
        listOfWhiteKeyImages.Add(G2);
        listOfBlackKeyImages.Add(GSharpAFlat2);
        listOfWhiteKeyImages.Add(A2);
        listOfBlackKeyImages.Add(ASharpBFlat2);
        listOfWhiteKeyImages.Add(B2);

     
        firstOctaveMasterChordDict.Add(MasterChord.F, F0);
        firstOctaveMasterChordDict.Add(MasterChord.FSharp, FSharpGFlat0);
        firstOctaveMasterChordDict.Add(MasterChord.GFlat, FSharpGFlat0);
        firstOctaveMasterChordDict.Add(MasterChord.G, G0);
        firstOctaveMasterChordDict.Add(MasterChord.GSharp, GSharpAFlat0);
        firstOctaveMasterChordDict.Add(MasterChord.AFlat, GSharpAFlat0);
        firstOctaveMasterChordDict.Add(MasterChord.A, A0);
        firstOctaveMasterChordDict.Add(MasterChord.ASharp, ASharpBFlat0);
        firstOctaveMasterChordDict.Add(MasterChord.BFlat, ASharpBFlat0);
        firstOctaveMasterChordDict.Add(MasterChord.B, B0);
        firstOctaveMasterChordDict.Add(MasterChord.C, C1);
        firstOctaveMasterChordDict.Add(MasterChord.CSharp, CSharpDFlat1);
        firstOctaveMasterChordDict.Add(MasterChord.DFlat, CSharpDFlat1);
        firstOctaveMasterChordDict.Add(MasterChord.D, D1);
        firstOctaveMasterChordDict.Add(MasterChord.DSharp, DSharpEFlat1);
        firstOctaveMasterChordDict.Add(MasterChord.EFlat, DSharpEFlat1);
        firstOctaveMasterChordDict.Add(MasterChord.E, E1);


        keyTextDict.Add(F0, F0Text);
        keyTextDict.Add(FSharpGFlat0, FSharpGFlat0Text);
        keyTextDict.Add(G0, G0Text);
        keyTextDict.Add(GSharpAFlat0, GSharpAFlat0Text);
        keyTextDict.Add(A0, A0Text);
        keyTextDict.Add(ASharpBFlat0, ASharpBFlat0Text);
        keyTextDict.Add(B0, B0Text);
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
       

    }
}
