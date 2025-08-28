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
        foreach (GameObject button in uIController.inversionButtons)
        {
            button.SetActive(false);
        }

        switch (chordController.currentChord.intervalsList.Count)
        {

                case 3:
                uIController.rootPositionInversionButton.SetActive(true);
                uIController.firstInversionButton.SetActive(true);
                uIController.secondInversionButton.SetActive(true);
                break;

            case 4:
                uIController.rootPositionInversionButton.SetActive(true);
                uIController.firstInversionButton.SetActive(true);
                uIController.secondInversionButton.SetActive(true);
                uIController.thirdInversionButton.SetActive(true);
                break;

            default:
                uIController.rootPositionInversionButton.SetActive(true);
                break;

        }




    }
}
