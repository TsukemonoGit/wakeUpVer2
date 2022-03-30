using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeController : MonoBehaviour
{ 
    Material fadeMaterial;
    bool nowFadeIn;
    bool nowFadeOut;
    float interval = 2f;
    float  nowFloat=-1;
    public int loadSceneIndex;
    Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        fadeMaterial = image.material;
        if (fadeMaterial == null){
            Debug.Log("nai");
        }
        fadeMaterial.SetFloat("_Float", -1.1f);
        image.enabled=(false);
    }
    public void StartFadeIn(int index)
    {
        nowFadeIn = true;
        loadSceneIndex = index;
        image.enabled = true;
     }
    public void StartFadeOut(int index)
    {
        nowFadeOut=true;
        loadSceneIndex = index;
    }
    private void Update()
    {
        if (nowFadeIn && !nowFadeOut)
        {
            fadeMaterial.SetFloat("_Float", nowFloat);
            nowFloat+=interval*Time.deltaTime;
            if (nowFloat > 1)
            {
                fadeMaterial.SetFloat("_Float", 1);
                nowFadeIn = false;
                SceneManager.LoadScene(loadSceneIndex);
                nowFadeOut = true;
            }

        }else if (nowFadeOut && !nowFadeIn)
        {
            fadeMaterial.SetFloat("_Float", nowFloat);
            nowFloat-=interval*Time.deltaTime;
            if (nowFloat < -1)
            {
                fadeMaterial.SetFloat("_Float", -1.1f);
                nowFadeOut = false;
                image.enabled = false;
            }

        }
    }
}
