using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;

public class ObjectManager : MonoBehaviour
{
    public List<GameObject> models = new List<GameObject>();
    private Transform trn;
    public int selection = 0,selMax;
    public TMP_Text tmpName;
    // Start is called before the first frame update
    void Start()
    {
        trn = this.GetComponent<Transform>();
        selMax = trn.childCount;
        for(int x = 0;x < trn.childCount;++x)
        {
            Debug.Log("list active");
            models.Add(trn.GetChild(x).gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
       if(selection >= selMax)
        {
            selection = 0;
        }
        if(selection < 0)
        {
            Debug.Log("under 0");
            selection = selMax-1;
        }
        foreach(GameObject model in models)
        {
            int curSel = model.GetComponent<Transform>().GetSiblingIndex();
            if (selection == curSel)
            {
                tmpName.text = model.name;
                model.SetActive(true);
            }
            else
            {
                model.SetActive(false);
            }
        } 
    }
    public void _MoveSelection(int incAmount)
    {
        selection += incAmount;
    }
}
