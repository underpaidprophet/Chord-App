using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    }
}
