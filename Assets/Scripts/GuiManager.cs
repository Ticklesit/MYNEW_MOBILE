using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GuiManager : MonoBehaviour
{
    public TMP_Text tmp;
    // Start is called before the first frame update
    void Start()
    {
        LoadText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadText()
    {
        StartCoroutine("_Wait");
    }
    IEnumerator _Wait()
        {
            float seconds = .5f;
            yield return new WaitForSeconds(seconds);
            tmp.text = "Loading";
            yield return new WaitForSeconds(seconds);
            tmp.text = "Loading.";
            yield return new WaitForSeconds(seconds);
            tmp.text = "Loading..";
            yield return new WaitForSeconds(seconds);
            tmp.text = "Loading...";
            yield return new WaitForSeconds(seconds);
            StopCoroutine("_Wait");
            LoadText();
        } 
}
