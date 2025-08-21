using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Chord : ScriptableObject
{
    public ChordType chordType;
    public List<Intervals> intervalsList;
}
