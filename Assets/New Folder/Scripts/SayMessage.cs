using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SayMessage : MonoBehaviour
{
  //  public
 // string message;
  //  public TMP_Text messageBox;
    public InputManager _input;
  //  public GameObject MessageCanvas;
  [Header("呼びかけ判定秒数")]
    public float seconds;
    public GameController gameCon;
   // public bool isSendingMessage;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        //if (gameCon.timeLimit.y == 0)
        //{
        //    message = "今日" + gameCon.timeLimit.x + "時から\n配信します。";
        //}
        //else
        //{
        //    message = "今日" + gameCon.timeLimit.x + "時"+gameCon.timeLimit.y +"分から\n配信します。";

        //}
    }
    Animator anim;
    public ParticleSystem particle;
    // Update is called once per frame
    void Update()
    {
        if (_input.say)
        {
            anim.SetBool("megahon", true);
            if (!particle.isPlaying)
            {
                particle.Play();
            }
            _input.say = false;
       //     messageBox.text = message;
        //    MessageCanvas.SetActive(true);
            if (!gameCon.isSendingMessage)
            {
                StartCoroutine(TextCoroutine());
            }
        }
    }
    IEnumerator TextCoroutine()
    {
        gameCon.isSendingMessage = true;
        yield return new WaitForSeconds(seconds);
     //   MessageCanvas.SetActive(false);
        gameCon.isSendingMessage = false;
        anim.SetBool("megahon", false);
    }
}
