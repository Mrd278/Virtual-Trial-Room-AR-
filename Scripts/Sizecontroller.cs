using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Sizecontroller : MonoBehaviour
{
    public Text h;
    public Text w;

    public void Play()
    {
        float height = float.Parse(h.text);
        float width = float.Parse(w.text);
        Debug.Log("SizeController - height: " + height + " Width: " + width);
        PlayerPrefs.SetFloat("height", height);
        PlayerPrefs.SetFloat("width", width);
        SceneManager.LoadScene(1);
    }
}
