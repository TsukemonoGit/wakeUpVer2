using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
   public void SetHandAnim(int index)
    {
        anim.SetFloat("hand", index);
    }
    public void PonHand(bool value)
    {
        anim.SetBool("pon", value);
    }
}
