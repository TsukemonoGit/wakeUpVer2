using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JankenAnimator : MonoBehaviour
{

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void Janken(bool janPon)
    {
        anim.SetBool("janPon", janPon);

    }
    public void PonHand(int index)
    {
        anim.SetFloat("jankenHand", index);
    }
}
