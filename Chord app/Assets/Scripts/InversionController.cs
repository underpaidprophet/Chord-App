using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InversionController : MonoBehaviour
{
    public ChordController chordController;
    public UIController uIController;
    public List<int> RootPoositionSemitones(List<int> list)
    {

        List<int> returnList = new List<int>();


        for (int i = 0; i < list.Count; i++)
        {
            int semitones = list[i];
           
            returnList.Add(semitones);
        }

        return returnList;
    }

    public List<int> FirstInversionSemitones(List<int> list)
    {

        List<int> returnList = new List<int>();


        for (int i = 0; i < list.Count; i++)
        {
            int semitones = list[i];
            if(i == 0)
            {
                semitones = semitones + 12;
            }
            returnList.Add(semitones);
        }

        return returnList;
    }


    public List<int> SecondInversionSemitones(List<int> list)
    {

        List<int> returnList = new List<int>();


        for (int i = 0; i < list.Count; i++)
        {
            int semitones = list[i];
            if (i == 0 || i == 1)
            {
                semitones = semitones + 12;
            }
            returnList.Add(semitones);
        }

        return returnList;
    }

    public List<int> ThirdInversionSemitones(List<int> list)
    {

        List<int> returnList = new List<int>();


        for (int i = 0; i < list.Count; i++)
        {
            int semitones = list[i];
            if (i == 0 || i == 1 || i == 2)
            {
                semitones = semitones + 12;
            }
            returnList.Add(semitones);
        }

        return returnList;
    }

    
    public void SetInversionButtons()
    {

        
        foreach (Transform child in uIController.inversionButtonParent.transform)
        {
            Destroy(child.gameObject);
        }

        GameObject buttonGO = new GameObject();
        InversionButtonPrefabScrpt script;

        switch (chordController.currentChord.intervalsList.Count)
        {
           

                case 3:
                for (int i = 0; i < 3; i++)
                {
                     buttonGO = Instantiate(uIController.inversionButtonPrefab, uIController.inversionButtonParent.transform);


                    script = buttonGO.GetComponent<InversionButtonPrefabScrpt>();

                    script.thisInversion = (Inversions)i;

                    script.chordController = chordController;
                    script.uIController = uIController;
                    //    script.buttonText.text = chordController.masterChordNameDict[masterChord];

                    script.buttonText.text = chordController.masterChordNameDict[chordController.currentMasterChord] + chordController.chordTypeNameDict[chordController.currentChord.chordType];
                    script.inversionName.text = uIController.inversionsNameDict[script.thisInversion];

                    if (i > 0)
                    {
                        script.buttonText.text = script.buttonText.text + "/" + chordController.noteNameDict[chordController.notesInCurrentChord[i]];
                    }

                    script.button.onClick.AddListener(script.ClickedOn);

                }

                break;

            case 4:
                for (int i = 0; i < 4; i++)
                {
                     buttonGO = Instantiate(uIController.inversionButtonPrefab, uIController.inversionButtonParent.transform);


                     script = buttonGO.GetComponent<InversionButtonPrefabScrpt>();

                    script.thisInversion = (Inversions)i;

                    script.chordController = chordController;
                    script.uIController = uIController;
                    //    script.buttonText.text = chordController.masterChordNameDict[masterChord];
                    script.buttonText.text = chordController.masterChordNameDict[chordController.currentMasterChord] + chordController.chordTypeNameDict[chordController.currentChord.chordType];
                    script.inversionName.text = uIController.inversionsNameDict[script.thisInversion];

                    if (i > 0)
                    {
                        script.buttonText.text = script.buttonText.text + "/" + chordController.noteNameDict[chordController.notesInCurrentChord[i]];
                    }


                    script.button.onClick.AddListener(script.ClickedOn);

                }
                break;

            default:
                 buttonGO = Instantiate(uIController.inversionButtonPrefab, uIController.inversionButtonParent.transform);


                 script = buttonGO.GetComponent<InversionButtonPrefabScrpt>();

                script.thisInversion = (Inversions)0;

                script.chordController = chordController;
                script.uIController = uIController;
            
                script.buttonText.text = chordController.masterChordNameDict[chordController.currentMasterChord] + chordController.chordTypeNameDict[chordController.currentChord.chordType];


                script.button.onClick.AddListener(script.ClickedOn);
                break;

        }
        

    }

    
    
    


}
