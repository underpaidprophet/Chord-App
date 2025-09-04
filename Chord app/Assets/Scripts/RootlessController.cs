using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootlessController : MonoBehaviour
{
    public ChordController chordController;
    public UIController uIController;

    public Chord RootlessChord(Chord chord)
    {
        Chord newChord = ScriptableObject.CreateInstance<Chord>();
        newChord.name = chord.name;

        switch (chordController.chordQualityDict[chord.chordType])
        {
            case ChordQuality.Major:
                newChord.intervalsList = MajorAndMinorRootlessIntervals(chord);
                break;
            case ChordQuality.Minor:
                newChord.intervalsList = MajorAndMinorRootlessIntervals(chord);
                break;
            case ChordQuality.Dominant:
                newChord.intervalsList = DominantRootlessIntervals(chord);
                break;
             

        }
      

        return newChord;
    }


    public List<Intervals> MajorAndMinorRootlessIntervals(Chord chord)
    {

        List<Intervals> newList = new List<Intervals>();
        foreach (Intervals interval in chord.intervalsList)
        {
            if (chordController.intervalIntDict[interval] == 3 || chordController.intervalIntDict[interval] == 5 || chordController.intervalIntDict[interval] == 7)
            {
                newList.Add(interval);
            }

        }
        newList.Add(Intervals.MajorNinth);
        return newList;
    }
    public List<Intervals> DominantRootlessIntervals(Chord chord)
    {

        List<Intervals> newList = new List<Intervals>();
        foreach (Intervals interval in chord.intervalsList)
        {
            if (chordController.intervalIntDict[interval] == 3 || chordController.intervalIntDict[interval] == 7)
            {
                newList.Add(interval);
            }


        }
        newList.Add(Intervals.MajorNinth);
        newList.Add(Intervals.MajorThirteenth);

        return newList;
    }

    public void RootlessButton()
    {
        uIController.currentChordVariation = ChordVariation.Rootless;
        uIController.rootThreeSevenButtonParent.SetActive(false);
        uIController.inversionButtonParent.SetActive(false);

        //resetting it all
        chordController.currentInversion = Inversions.RootPosition;
       
        uIController.ShowChordKeys(chordController.currentMasterChord, RootlessChord(chordController.currentChord));
        uIController.SetChordInversionText();
    }

}


public enum RootlessVariations
{
    Major,
    Minor,
    DominantSeventh
}

public enum RootlessVoicingType
{
    A,
    B
}

