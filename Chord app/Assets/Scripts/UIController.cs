using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    //orange = ffbb40

    // the piano keys

    public bool isOn;

    public Sprite orangeKey;
    public Sprite blackKey;

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

    public Color white;
    public Color orange;

    public List<Image> ListOfKeyImages = new List<Image>();
    public List<Image> ListOfWhiteKeyImages = new List<Image>();
    public List<Image> ListOfBlackKeyImages = new List<Image>();

    private void Awake()
    {
        ListOfKeyImages.Add(C1);
        ListOfKeyImages.Add(CSharpDFlat1);
        ListOfKeyImages.Add(D1);
        ListOfKeyImages.Add(DSharpEFlat1);
        ListOfKeyImages.Add(E1);
        ListOfKeyImages.Add(F1);
        ListOfKeyImages.Add(FSharpGFlat1);
        ListOfKeyImages.Add(G1);
        ListOfKeyImages.Add(GSharpAFlat1);
        ListOfKeyImages.Add(A1);
        ListOfKeyImages.Add(ASharpBFlat1);
        ListOfKeyImages.Add(B1);
        ListOfKeyImages.Add(C2);
        ListOfKeyImages.Add(CSharpDFlat2);
        ListOfKeyImages.Add(D2);
        ListOfKeyImages.Add(DSharpEFlat2);
        ListOfKeyImages.Add(E2);
        ListOfKeyImages.Add(F2);
        ListOfKeyImages.Add(FSharpGFlat2);
        ListOfKeyImages.Add(G2);
        ListOfKeyImages.Add(GSharpAFlat2);
        ListOfKeyImages.Add(A2);
        ListOfKeyImages.Add(ASharpBFlat2);
        ListOfKeyImages.Add(B2);

        ListOfWhiteKeyImages.Add(C1);
        ListOfBlackKeyImages.Add(CSharpDFlat1);
        ListOfWhiteKeyImages.Add(D1);
        ListOfBlackKeyImages.Add(DSharpEFlat1);
        ListOfWhiteKeyImages.Add(E1);
        ListOfWhiteKeyImages.Add(F1);
        ListOfBlackKeyImages.Add(FSharpGFlat1);
        ListOfWhiteKeyImages.Add(G1);
        ListOfBlackKeyImages.Add(GSharpAFlat1);
        ListOfWhiteKeyImages.Add(A1);
        ListOfBlackKeyImages.Add(ASharpBFlat1);
        ListOfWhiteKeyImages.Add(B1);
        ListOfWhiteKeyImages.Add(C2);
        ListOfBlackKeyImages.Add(CSharpDFlat2);
        ListOfWhiteKeyImages.Add(D2);
        ListOfBlackKeyImages.Add(DSharpEFlat2);
        ListOfWhiteKeyImages.Add(E2);
        ListOfWhiteKeyImages.Add(F2);
        ListOfBlackKeyImages.Add(FSharpGFlat2);
        ListOfWhiteKeyImages.Add(G2);
        ListOfBlackKeyImages.Add(GSharpAFlat2);
        ListOfWhiteKeyImages.Add(A2);
        ListOfBlackKeyImages.Add(ASharpBFlat2);
        ListOfWhiteKeyImages.Add(B2);

        ResetKeyColor();

    }

    private void Start()
    {
        ResetKeyColor();
    }

    public void ResetKeyColor()
    {
        foreach (Image key in ListOfKeyImages)
        {
            if(ListOfWhiteKeyImages.Contains(key))
            {
                key.color = white;
            }

            if (ListOfBlackKeyImages.Contains(key))
            {
                key.sprite = blackKey;
            }
        }

        isOn = false;
    }

    public void SetKeyColour(Image key)
    {

        if (ListOfWhiteKeyImages.Contains(key))
        {
            key.color = orange;
        }

        if (ListOfBlackKeyImages.Contains(key))
        {
            key.sprite = orangeKey;
        }

        isOn = true;


    }

    public void TestButton()
    {
        switch (isOn)
        {
            case true:
                ResetKeyColor();
                break;
            case false:
                foreach (Image key in ListOfKeyImages)
                {
                    SetKeyColour(key);
                }
                break;
        }


    }
}

