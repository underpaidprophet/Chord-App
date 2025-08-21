using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChordController : MonoBehaviour
{
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
    public Chord halfDimSeventh;
    public Chord minorSeventhFlatFifth;
    public Chord aug;
    public Chord augSeventh;

    public MasterChord currentMasterChord;
    public Chord currentChord;

    public List<int> chordIntervals = new List<int>();


    

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
    }

    public void Start()
    {
        //for testing 
        currentMasterChord = MasterChord.C;

        currentChord = dominantSeventh;


       

    }

    public void GetNotesButton()
    {
        chordIntervals = CalculateNotes(currentMasterChord, currentChord);

        //testing
        Debug.Log(currentChord);
        for (int i = 0; i < chordIntervals.Count; i++)
        {
            Debug.Log(currentChord.intervalsList[i] + " " + chordIntervals[i]);
        }
    }

    public List<int> CalculateNotes(MasterChord masterChord, Chord chord)
    {
        List<int> list = new List<int>();
        chordIntervals.Clear();

        foreach (Intervals interval in currentChord.intervalsList)
        {
            list.Add(intervalsSemitonesDictionary[interval]);
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
   HalfDimSeventh,
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




