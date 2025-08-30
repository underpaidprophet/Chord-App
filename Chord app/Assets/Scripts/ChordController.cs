using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChordController : MonoBehaviour
{

    public UIController uIController;
    Dictionary<Intervals, int> intervalsSemitonesDictionary = new Dictionary<Intervals, int>();

    public Chord major;
    public Chord minor;
    public Chord dominantSeventh;
    public Chord minorSeventh;
    public Chord majorSeventh;
    public Chord minorMajorSeventh;
    public Chord sixth;
    public Chord minorSixth;
    public Chord sixthNinth;
    public Chord fifth;
    public Chord dominantNinth;
    public Chord minorNinth;
    public Chord majorNinth;
    public Chord dominantEleventh;
    public Chord minorEleventh;
    public Chord majorEleventh;
    public Chord dominantThirteenth;
    public Chord minorThirteenth;
    public Chord majorThirteenth;
    public Chord addNinth;
    public Chord addSecond;
    public Chord seventhFlatFifth;
    public Chord seventhSharpFifth;
    public Chord sus2;
    public Chord sus4;
    public Chord dim;
    public Chord dimSeventh;
   
    public Chord minorSeventhFlatFifth;
    public Chord aug;
    public Chord augSeventh;


    public Scale C;
    public Scale CSharp;
    public Scale DFlat;
    public Scale D;
    public Scale DSharp;
    public Scale EFlat;
    public Scale E;
    public Scale F;
    public Scale FSharp;
    public Scale GFlat;
    public Scale G;
    public Scale GSharp;
    public Scale AFlat;
    public Scale A;
    public Scale ASharp;
    public Scale BFlat;
    public Scale B;

    public MasterChord currentMasterChord;
    public Chord currentChord;
    

    public List<int> chordIntervals = new List<int>();

    public Dictionary<ChordType, Chord> chordTypeDict = new Dictionary<ChordType, Chord>();


    public Dictionary<MasterChord, string> masterChordNameDict = new Dictionary<MasterChord, string>();
    public Dictionary<ChordType, string> chordTypeNameDict = new Dictionary<ChordType, string>();

    public Dictionary<Intervals, string> intervalNamesDict = new Dictionary<Intervals, string>();

    public Inversions currentInversion = Inversions.RootPosition;

    public List<Notes> currentChordNotesList = new List<Notes>();

    public Dictionary<MasterChord, Scale> scaleDict = new Dictionary<MasterChord, Scale>();
    public Dictionary<Intervals, int> intervalIntDict = new Dictionary<Intervals, int>();


    public Dictionary<Intervals, Adjustment> adjustmentDict = new Dictionary<Intervals, Adjustment>();

    private void Awake()
    {

        intervalsSemitonesDictionary.Add(Intervals.Root, 0);
        intervalsSemitonesDictionary.Add(Intervals.MinorSecond, 1);
        intervalsSemitonesDictionary.Add(Intervals.MajorSecond, 2);
        intervalsSemitonesDictionary.Add(Intervals.MinorThird, 3);
        intervalsSemitonesDictionary.Add(Intervals.MajorThird, 4);
        intervalsSemitonesDictionary.Add(Intervals.PerfectFourth, 5);
        intervalsSemitonesDictionary.Add(Intervals.AugmentedFourth, 6);
        intervalsSemitonesDictionary.Add(Intervals.DiminishedFifth, 6);
        intervalsSemitonesDictionary.Add(Intervals.PerfectFifth, 7);
        intervalsSemitonesDictionary.Add(Intervals.AugmentedFifth, 8);
        intervalsSemitonesDictionary.Add(Intervals.MinorSixth, 8);
        intervalsSemitonesDictionary.Add(Intervals.MajorSixth, 9);
        intervalsSemitonesDictionary.Add(Intervals.DiminishedSeventh, 9);
        intervalsSemitonesDictionary.Add(Intervals.MinorSeventh, 10);
        intervalsSemitonesDictionary.Add(Intervals.MajorSeventh, 11);
        intervalsSemitonesDictionary.Add(Intervals.Octave, 12);
        intervalsSemitonesDictionary.Add(Intervals.MinorNinth, 13);
        intervalsSemitonesDictionary.Add(Intervals.MajorNinth, 14);
        intervalsSemitonesDictionary.Add(Intervals.MinorTenth, 15);
        intervalsSemitonesDictionary.Add(Intervals.MajorTenth, 16);
        intervalsSemitonesDictionary.Add(Intervals.PerfectEleventh, 17);
        intervalsSemitonesDictionary.Add(Intervals.AugmentedEleventh, 18);
        intervalsSemitonesDictionary.Add(Intervals.DiminishedTwelfth, 18);
        intervalsSemitonesDictionary.Add(Intervals.PerfectTwelfth, 19);
        intervalsSemitonesDictionary.Add(Intervals.MinorThirteenth, 20);
        intervalsSemitonesDictionary.Add(Intervals.MajorThirteenth, 21);
        intervalsSemitonesDictionary.Add(Intervals.MinorFourteenth, 22);
        intervalsSemitonesDictionary.Add(Intervals.MajorFourteenth, 23);
        intervalsSemitonesDictionary.Add(Intervals.Fifteenth, 24);

        masterChordNameDict.Add(MasterChord.C, "C");
        masterChordNameDict.Add(MasterChord.CSharp, "C#");
        masterChordNameDict.Add(MasterChord.DFlat, "Db");
        masterChordNameDict.Add(MasterChord.D, "D");
        masterChordNameDict.Add(MasterChord.DSharp, "D#");
        masterChordNameDict.Add(MasterChord.EFlat, "Eb");
        masterChordNameDict.Add(MasterChord.E, "E");
        masterChordNameDict.Add(MasterChord.F, "F");
        masterChordNameDict.Add(MasterChord.FSharp, "F#");
        masterChordNameDict.Add(MasterChord.GFlat, "Gb");
        masterChordNameDict.Add(MasterChord.G, "G");
        masterChordNameDict.Add(MasterChord.GSharp, "G#");
        masterChordNameDict.Add(MasterChord.AFlat, "Ab");
        masterChordNameDict.Add(MasterChord.A, "A");
        masterChordNameDict.Add(MasterChord.ASharp, "A#");
        masterChordNameDict.Add(MasterChord.BFlat, "Bb");
        masterChordNameDict.Add(MasterChord.B, "B");


        chordTypeNameDict.Add(ChordType.Major, "");
        chordTypeNameDict.Add(ChordType.Minor, "-");
        chordTypeNameDict.Add(ChordType.DominantSeventh, "7");
        chordTypeNameDict.Add(ChordType.MinorSeventh, "-7");
        chordTypeNameDict.Add(ChordType.MajorSeventh, "maj7");
        chordTypeNameDict.Add(ChordType.MinorMajorSeventh, "mM7");
        chordTypeNameDict.Add(ChordType.Sixth, "6");
        chordTypeNameDict.Add(ChordType.MinorSixth, "-6");
        chordTypeNameDict.Add(ChordType.SixthNinth, "6/9");
        chordTypeNameDict.Add(ChordType.Fifth, "5");
        chordTypeNameDict.Add(ChordType.DominantNinth, "9");
        chordTypeNameDict.Add(ChordType.MinorNinth, "-9");
        chordTypeNameDict.Add(ChordType.MajorNinth, "maj9");
        chordTypeNameDict.Add(ChordType.DominantEleventh, "11");
        chordTypeNameDict.Add(ChordType.MinorEleventh, "-11");
        chordTypeNameDict.Add(ChordType.MajorEleventh, "maj11");
        chordTypeNameDict.Add(ChordType.DominantThirteenth, "13");
        chordTypeNameDict.Add(ChordType.MinorThirteenth, "-13");
        chordTypeNameDict.Add(ChordType.MajorThirteenth, "maj13");
        chordTypeNameDict.Add(ChordType.AddNinth, "add9");
        chordTypeNameDict.Add(ChordType.AddSecond, "add2");
        chordTypeNameDict.Add(ChordType.SeventhFlatFifth, "7b5");
        chordTypeNameDict.Add(ChordType.SeventhSharpFifth, "7#5");
        chordTypeNameDict.Add(ChordType.Sus2, "sus2");
        chordTypeNameDict.Add(ChordType.Sus4, "sus4");
        chordTypeNameDict.Add(ChordType.Dim, "°");
        chordTypeNameDict.Add(ChordType.DimSeventh, "°7");
        chordTypeNameDict.Add(ChordType.MinorSeventhFlatFifth, "m7b5");
        chordTypeNameDict.Add(ChordType.Aug, "aug");
        chordTypeNameDict.Add(ChordType.AugSeventh, "aug7");

        chordTypeDict.Add(ChordType.Major, major);
        chordTypeDict.Add(ChordType.Minor, minor);
        chordTypeDict.Add(ChordType.DominantSeventh, dominantSeventh);
        chordTypeDict.Add(ChordType.MinorSeventh, minorSeventh);
        chordTypeDict.Add(ChordType.MajorSeventh,majorSeventh);
        chordTypeDict.Add(ChordType.MinorMajorSeventh,minorMajorSeventh);
        chordTypeDict.Add(ChordType.Sixth, sixth);
        chordTypeDict.Add(ChordType.MinorSixth, minorSixth);
        chordTypeDict.Add(ChordType.SixthNinth,sixthNinth);
        chordTypeDict.Add(ChordType.Fifth, fifth);
        chordTypeDict.Add(ChordType.DominantNinth, dominantNinth);
        chordTypeDict.Add(ChordType.MinorNinth, minorNinth);
        chordTypeDict.Add(ChordType.MajorNinth, majorNinth);
        chordTypeDict.Add(ChordType.DominantEleventh, dominantEleventh);
        chordTypeDict.Add(ChordType.MinorEleventh, minorEleventh);
        chordTypeDict.Add(ChordType.MajorEleventh, majorEleventh);
        chordTypeDict.Add(ChordType.DominantThirteenth, dominantThirteenth);
        chordTypeDict.Add(ChordType.MinorThirteenth, minorThirteenth);
        chordTypeDict.Add(ChordType.MajorThirteenth, majorThirteenth);
        chordTypeDict.Add(ChordType.AddNinth, addNinth);
        chordTypeDict.Add(ChordType.AddSecond, addSecond);
        chordTypeDict.Add(ChordType.SeventhFlatFifth, seventhFlatFifth);
        chordTypeDict.Add(ChordType.SeventhSharpFifth, seventhSharpFifth);
        chordTypeDict.Add(ChordType.Sus2, sus2);
        chordTypeDict.Add(ChordType.Sus4, sus4);
        chordTypeDict.Add(ChordType.Dim, dim);
        chordTypeDict.Add(ChordType.DimSeventh, dimSeventh);
        chordTypeDict.Add(ChordType.MinorSeventhFlatFifth, minorSeventhFlatFifth);
        chordTypeDict.Add(ChordType.Aug, aug);
        chordTypeDict.Add(ChordType.AugSeventh, augSeventh);

        intervalNamesDict.Add(Intervals.Root, "R");
        intervalNamesDict.Add(Intervals.MinorSecond, "b2");
        intervalNamesDict.Add(Intervals.MajorSecond, "2");
        intervalNamesDict.Add(Intervals.MinorThird, "b3");
        intervalNamesDict.Add(Intervals.MajorThird, "3");
        intervalNamesDict.Add(Intervals.PerfectFourth, "4");
        intervalNamesDict.Add(Intervals.AugmentedFourth, "#4");
        intervalNamesDict.Add(Intervals.DiminishedFifth, "bb5");
        intervalNamesDict.Add(Intervals.PerfectFifth, "5");
        intervalNamesDict.Add(Intervals.AugmentedFifth, "#5");
        intervalNamesDict.Add(Intervals.MinorSixth, "b6");
        intervalNamesDict.Add(Intervals.MajorSixth, "6");
        intervalNamesDict.Add(Intervals.DiminishedSeventh, "bb7");
        intervalNamesDict.Add(Intervals.MinorSeventh, "b7");
        intervalNamesDict.Add(Intervals.MajorSeventh, "7");
        intervalNamesDict.Add(Intervals.Octave, "R");
        intervalNamesDict.Add(Intervals.MinorNinth, "b9");
        intervalNamesDict.Add(Intervals.MajorNinth, "9");
        intervalNamesDict.Add(Intervals.MinorTenth, "b10");
        intervalNamesDict.Add(Intervals.MajorTenth, "10");
        intervalNamesDict.Add(Intervals.PerfectEleventh, "11");
        intervalNamesDict.Add(Intervals.AugmentedEleventh, "#11");
        intervalNamesDict.Add(Intervals.DiminishedTwelfth, "bb12");
        intervalNamesDict.Add(Intervals.PerfectTwelfth, "12");
        intervalNamesDict.Add(Intervals.MinorThirteenth, "b13");
        intervalNamesDict.Add(Intervals.MajorThirteenth, "13");
        intervalNamesDict.Add(Intervals.MinorFourteenth, "b14");
        intervalNamesDict.Add(Intervals.MajorFourteenth, "14");
        intervalNamesDict.Add(Intervals.Fifteenth, "15");

        scaleDict.Add(MasterChord.C, C);
    scaleDict.Add(MasterChord.CSharp, CSharp);
        scaleDict.Add(MasterChord.DFlat, DFlat);
    scaleDict.Add(MasterChord.D, D);
        scaleDict.Add(MasterChord.DSharp, DSharp);
    scaleDict.Add(MasterChord.EFlat, EFlat);
        scaleDict.Add(MasterChord.E,E);
        scaleDict.Add(MasterChord.F,F);
        scaleDict.Add(MasterChord.FSharp, FSharp);
        scaleDict.Add(MasterChord.GFlat, GFlat);
        scaleDict.Add(MasterChord.G,G);
        scaleDict.Add(MasterChord.GSharp, GSharp);
        scaleDict.Add(MasterChord.AFlat, AFlat);
        scaleDict.Add(MasterChord.A, A);
        scaleDict.Add(MasterChord.ASharp, ASharp);

        scaleDict.Add(MasterChord.BFlat, BFlat);
        scaleDict.Add(MasterChord.B, B);

        intervalIntDict.Add(Intervals.Root, 0);
        intervalIntDict.Add(Intervals.MinorSecond, 2);
        intervalIntDict.Add(Intervals.MajorSecond, 2);
        intervalIntDict.Add(Intervals.MinorThird, 3);
        intervalIntDict.Add(Intervals.MajorThird, 3);
        intervalIntDict.Add(Intervals.PerfectFourth, 4);
        intervalIntDict.Add(Intervals.AugmentedFourth, 4);
        intervalIntDict.Add(Intervals.DiminishedFifth, 5);
        intervalIntDict.Add(Intervals.PerfectFifth, 5);
        intervalIntDict.Add(Intervals.AugmentedFifth, 5);
        intervalIntDict.Add(Intervals.MinorSixth, 6);
        intervalIntDict.Add(Intervals.MajorSixth, 6);
        intervalIntDict.Add(Intervals.DiminishedSeventh, 7);
        intervalIntDict.Add(Intervals.MinorSeventh, 7);
        intervalIntDict.Add(Intervals.MajorSeventh, 7);
        intervalIntDict.Add(Intervals.Octave, 8);
        intervalIntDict.Add(Intervals.MinorNinth, 9);
        intervalIntDict.Add(Intervals.MajorNinth, 9);
        intervalIntDict.Add(Intervals.MinorTenth, 10);
        intervalIntDict.Add(Intervals.MajorTenth, 10);
        intervalIntDict.Add(Intervals.PerfectEleventh, 11);
        intervalIntDict.Add(Intervals.AugmentedEleventh, 11);
        intervalIntDict.Add(Intervals.DiminishedTwelfth, 12);
        intervalIntDict.Add(Intervals.PerfectTwelfth, 12);
        intervalIntDict.Add(Intervals.MinorThirteenth, 13);
        intervalIntDict.Add(Intervals.MajorThirteenth, 13);
        intervalIntDict.Add(Intervals.MinorFourteenth, 14);
        intervalIntDict.Add(Intervals.MajorFourteenth, 14);
        intervalIntDict.Add(Intervals.Fifteenth, 15);


        adjustmentDict.Add(Intervals.Root, Adjustment.None);
        adjustmentDict.Add(Intervals.MinorSecond, Adjustment.DownOne);
        adjustmentDict.Add(Intervals.MajorSecond, Adjustment.None);
        adjustmentDict.Add(Intervals.MinorThird, Adjustment.DownOne);
        adjustmentDict.Add(Intervals.MajorThird, Adjustment.None);
        adjustmentDict.Add(Intervals.PerfectFourth, Adjustment.None);
        adjustmentDict.Add(Intervals.AugmentedFourth, Adjustment.UpOne);
        adjustmentDict.Add(Intervals.DiminishedFifth,Adjustment.DownTwo);
        adjustmentDict.Add(Intervals.PerfectFifth, Adjustment.None);
        adjustmentDict.Add(Intervals.AugmentedFifth, Adjustment.UpOne);
        adjustmentDict.Add(Intervals.MinorSixth, Adjustment.DownOne);
        adjustmentDict.Add(Intervals.MajorSixth, Adjustment.None);
        adjustmentDict.Add(Intervals.DiminishedSeventh, Adjustment.DownTwo);
        adjustmentDict.Add(Intervals.MinorSeventh, Adjustment.DownOne);
        adjustmentDict.Add(Intervals.MajorSeventh, Adjustment.None);
        adjustmentDict.Add(Intervals.Octave, Adjustment.None);
        adjustmentDict.Add(Intervals.MinorNinth, Adjustment.DownOne);
        adjustmentDict.Add(Intervals.MajorNinth, Adjustment.None);
        adjustmentDict.Add(Intervals.MinorTenth, Adjustment.DownOne);
        adjustmentDict.Add(Intervals.MajorTenth, Adjustment.None);
        adjustmentDict.Add(Intervals.PerfectEleventh, Adjustment.None);
        adjustmentDict.Add(Intervals.AugmentedEleventh, Adjustment.UpOne);
        adjustmentDict.Add(Intervals.DiminishedTwelfth, Adjustment.DownTwo);
        adjustmentDict.Add(Intervals.PerfectTwelfth, Adjustment.None);
        adjustmentDict.Add(Intervals.MinorThirteenth, Adjustment.DownOne);
        adjustmentDict.Add(Intervals.MajorThirteenth, Adjustment.None);
        adjustmentDict.Add(Intervals.MinorFourteenth, Adjustment.DownOne);
        adjustmentDict.Add(Intervals.MajorFourteenth, Adjustment.None);
        adjustmentDict.Add(Intervals.Fifteenth, Adjustment.None);
    }

    public void Start()
    {
        //for testing 
        currentMasterChord = MasterChord.C;

        currentChord = dominantSeventh;

    }

    public void GetNotesButton()
    {
        chordIntervals.Clear();
        chordIntervals = CalculatIntervalss(currentMasterChord, currentChord);

        //testing
       // Debug.Log(currentChord);
        for (int i = 0; i < chordIntervals.Count; i++)
        {
          //  Debug.Log(currentChord.intervalsList[i] + " " + chordIntervals[i]);
        }
    }

    public List<int> CalculatIntervalss(MasterChord masterChord, Chord chord)
    {
     
        List<int> list = new List<int>();
        

        foreach (Intervals interval in chord.intervalsList)
        {
            list.Add(intervalsSemitonesDictionary[interval]);
        }

        return list;
    }

    public List<Notes> SetChordNotes(Chord chord, MasterChord masterChord, int offset)
    {
        List<Notes> list = new List<Notes>();
       
        Scale scale = scaleDict[masterChord];

        foreach (Intervals interval in chord.intervalsList)
        {
            if (interval == Intervals.Root)
            {
                list.Add(scale.notesInScale[intervalIntDict[interval]]);
            }
            if (interval != Intervals.Root)
            {
                list.Add(scale.notesInScale[intervalIntDict[interval]-1]);
            }
        }



        return list;
    }

    public List<Notes> AdjustNotes(List<Notes> notes, Chord chord)
    {
        List<Notes> list = new List<Notes>(notes);

        foreach (Intervals interval in chord.intervalsList)
        {
           // if(adjustmentDict[note].)
        }

        return list;
    }
}

public enum MasterChord
{
    C,
    CSharp,
    DFlat,
    D,
    DSharp,
    EFlat,
    E,
    F,
    FSharp,
    GFlat,
    G,
    GSharp,
    AFlat,
    A,
    ASharp,
    BFlat,
    B

}


public enum ChordType
{
   Major,
   Minor,
   DominantSeventh,
   MinorSeventh,
   MajorSeventh,
   MinorMajorSeventh,
   Sixth,
   MinorSixth,
   SixthNinth,
   Fifth,
   DominantNinth,
   MinorNinth,
   MajorNinth,
   DominantEleventh,
   MinorEleventh,
   MajorEleventh,
   DominantThirteenth,
   MinorThirteenth,
   MajorThirteenth,
   AddNinth,
   AddSecond,
   SeventhFlatFifth,
   SeventhSharpFifth,
   Sus2,
   Sus4,
   Dim,
   DimSeventh,
   MinorSeventhFlatFifth,
   Aug,
   AugSeventh

}

public enum Intervals
{
    Root,
    MinorSecond,
    MajorSecond,
    MinorThird,
    MajorThird,
    PerfectFourth,
    AugmentedFourth,
    DiminishedFifth,
    PerfectFifth,
    AugmentedFifth,
    MinorSixth,
    MajorSixth,
    DiminishedSeventh,
    MinorSeventh,
    MajorSeventh,
    Octave,
    MinorNinth,
    MajorNinth,
    MinorTenth,
    MajorTenth,
    PerfectEleventh,
    AugmentedEleventh,
    DiminishedTwelfth,
    PerfectTwelfth,
    MinorThirteenth,
    MajorThirteenth,
    MinorFourteenth,
    MajorFourteenth,
    Fifteenth

}

public enum Inversions
{
    RootPosition,
    FirstInversion,
    SecondInversion,
    ThirdInversion
}

public enum Notes
{
    C,
    CSharp,
    DFlat,
    D,
    DSharp,
    EFlat,
    E,
    ESharp,
    FFlat,
    F,
    FSharp,
    GFlat,
    G,
    GSharp,
    AFlat,
    A,
    ASharp,
    BFlat,
    B,
    BSharp,
    CFlat,
    CDoubleSharp,
    DDoubleSharp,
    EDoubleSharp,
    FDoubleSharp,
    GDoubleSharp,
    ADoubleSharp,
    BDoubleSharp,
    CDoubleFlat,
    DDoubleFlat,
    EDoubleFlat,
    FDoubleFlat,
    GDoubleFlat,
    ADoubleFlat,
    BDoubleFlat
}

public enum Adjustment
{
    DownTwo,
    DownOne,
    None,
    UpOne,
    UpTwo
}


