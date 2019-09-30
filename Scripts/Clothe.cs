using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clothe : MonoBehaviour
{
    public bool isselected = false;
    public GameObject[] other; 

    public void Change()
    {
        if (isselected)
        {
            isselected = false;
        }
        else
        {
            for(int i = 0; i < other.Length; i++)
            {
                if (other[i].GetComponent<Clothe>().isselected)
                {
                    other[i].GetComponent<Clothe>().Change();
                }
            }
            isselected = true;
        }
    }
}
