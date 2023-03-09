using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimPlayer : MonoBehaviour
{
    Animation anim;
    
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        anim = gameObject.GetComponent<Animation>();
        StartCoroutine(loadScene());
    }
    IEnumerator loadScene()
        {
            Scene scene = SceneManager.GetActiveScene();
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene("ObjectViewer");
            anim.Play("Fade out");
            StopCoroutine(loadScene());
        }

    // Update is called once per frame
    void Update()
    {
    }
}
