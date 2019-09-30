using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SizeChanger : MonoBehaviour
{
    public GameObject[] Tshirt;

    // Start is called before the first frame update
    void Start()
    {
        float height = PlayerPrefs.GetFloat("height");
        float width = PlayerPrefs.GetFloat("width");
        Debug.Log("height: " + height + " width: " + width);
        for(int i = 0; i< Tshirt.Length; i++)
        {
            Tshirt[i].transform.localScale = new Vector3(width, height, 1f);
        }
    }

    public void Update()
    {
        if (Tshirt[0].GetComponent<Clothe>().isselected)
        {
            Tshirt[0].SetActive(true);
            Tshirt[1].SetActive(false);
        }
        if (Tshirt[1].GetComponent<Clothe>().isselected)
        {
            Tshirt[1].SetActive(true);
            Tshirt[0].SetActive(false);
        }
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
