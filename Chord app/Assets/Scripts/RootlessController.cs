using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootlessController : MonoBehaviour
{
    public ChordController chordController;
    public UIController uIController;

    public Dictionary<RootlessVoicingType, string> voicingTypeNameDict = new Dictionary<RootlessVoicingType, string>();

    public RootlessVoicingType currentRootlessVoicingType;

    private void Awake()
    {
        voicingTypeNameDict.Add(RootlessVoicingType.MajorA, "type A\n3  5  7  9");
        voicingTypeNameDict.Add(RootlessVoicingType.MajorB, "type B\n7  9  3  5");

        voicingTypeNameDict.Add(RootlessVoicingType.MinorA, "type A\nb3  5  b7  9");
        voicingTypeNameDict.Add(RootlessVoicingType.MinorB, "type B\nb7  9  b3  5");

        voicingTypeNameDict.Add(RootlessVoicingType.DominantA, "type A\n3  13  b7  9");
        voicingTypeNameDict.Add(RootlessVoicingType.DominantB, "type B\nb7  9  3  13");



    }

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
        uIController.rootlessButtonParent.SetActive(true);
        
        //resetting it all
        chordController.currentInversion = Inversions.RootPosition;
        switch (chordController.chordQualityDict[chordController.currentChord.chordType])
        {
            case ChordQuality.Major:
                currentRootlessVoicingType = RootlessVoicingType.MajorA;
                break;
            case ChordQuality.Minor:
                currentRootlessVoicingType = RootlessVoicingType.MinorA;
                break;
            case ChordQuality.Dominant:
                currentRootlessVoicingType = RootlessVoicingType.DominantA;
                break;
            case ChordQuality.Augmented:
                break;
            case ChordQuality.Diminished:
                break;
            case ChordQuality.HalfDiminished:
                break;
            default:
                break;
        }

        /*
         *  case RootlessVoicingType.MajorA:
                currentRootlessVoicingType = RootlessVoicingType.MajorA;
                break;
         
            case RootlessVoicingType.DominantA:
                currentRootlessVoicingType = RootlessVoicingType.DominantA;
                break;
           
            default:
                currentRootlessVoicingType = RootlessVoicingType.MajorA;
                break;
         */


        foreach (Transform child in  uIController.rootlessButtonParent.transform)
        {
            Destroy(child.gameObject);
        }


        GameObject buttonGO;
        RootlessButtonPrefabScript script;


        //set the buttons
        for (int i = 0; i < 2; i++)
        {
            buttonGO = Instantiate(uIController.rootlessButtonPrefab, uIController.rootlessButtonParent.transform);


            script = buttonGO.GetComponent<RootlessButtonPrefabScript>();


            script.thisRootlessVoicingType = (RootlessVoicingType)i;
            script.chordController = chordController;
            script.uIController = uIController;
            script.inversion = (Inversions)i;
            script.rootlessController = this;

          

            //fix this
            switch (chordController.chordQualityDict[chordController.currentChord.chordType])
            {
                case ChordQuality.Major:
                    script.thisRootlessVoicingType = (RootlessVoicingType)(i);
                    script.inversion = (Inversions)i;
                    break;
                case ChordQuality.Minor:
                    
                    script.thisRootlessVoicingType = (RootlessVoicingType)(i+2);
                    script.inversion = (Inversions)i;
                    break;
                case ChordQuality.Dominant:
                    script.thisRootlessVoicingType = (RootlessVoicingType)(i+4);
                    script.inversion = (Inversions)i;
                    break;

                    /*
                case ChordQuality.Augmented:
                    break;
                case ChordQuality.Diminished:
                    break;
                case ChordQuality.HalfDiminished:
                    break;
                default:
                    break;
                    */
            }

          
            
            script.inversionName.text = voicingTypeNameDict[script.thisRootlessVoicingType];



            script.button.onClick.AddListener(script.ClickedOn);


        }

       
         
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
    MajorA,
    MajorB,
    MinorA,
    MinorB,
    DominantA,
    DominantB
}


