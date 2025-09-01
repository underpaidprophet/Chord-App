using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootThreeSevenController : MonoBehaviour
{
    public ChordController chordController;

   
    public Chord RootThreeSevenChord(Chord chord)
    {
        Chord newChord = ScriptableObject.CreateInstance<Chord>();
        newChord.name = chord.name;
        newChord.intervalsList = RootThreeSevenChordIntervals(chord);

        return newChord;
    }

    public List<Intervals> RootThreeSevenChordIntervals(Chord chord)
    {

        List<Intervals> newList = new List<Intervals>();
        foreach (Intervals interval in chord.intervalsList)
        {
            if (chordController.intervalIntDict[interval] == 0 || chordController.intervalIntDict[interval] == 3 || chordController.intervalIntDict[interval] == 7)
            {
                newList.Add(interval);
            }
        }

        return newList;
    }

}
