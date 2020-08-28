using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseItem : MonoBehaviour
{
    public void ChooseIndex(int index)
    {
        PlayerPrefs.SetInt("ITEM", index);
    }
}
