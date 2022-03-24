using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanzController : MonoBehaviour
{
    GameController gameCon;
 

    [Tooltip("ミッションとか")]
   public bool isMisshionClear=true;
    public bool isClearItem=true;
    
    Following following;
    
    [Tooltip("途中でファン図のマテリアル変える用")]
    public Material materialY;
    public Material materialB;
    public Material materialW;
    public SkinnedMeshRenderer meshRenderer;
    public SkinnedMeshRenderer skinRenderer;
    public FanzManager manager;
    // Start is called before the first frame update

    [Tooltip("こんすとれいんとに使う座標")]
    public Transform constraint;
    void Start()
    {
        gameCon = GameObject.FindWithTag("GameController").GetComponent<GameController>();
        following = GetComponent<Following>();
        manager = GetComponent<FanzManager>();
    }

    // Update is called once per frame
    void Update()
    {
       if( ! manager.isFollowing &&  isMisshionClear && isClearItem &&gameCon.canFollow && manager.inTrigger && gameCon.isSendingMessage)
        {
            manager.isFollowing = true;
            following.enabled=(true);  
            gameCon.nowFollowings.Add(this.gameObject);
            Instantiate(particle, particlePosition+transform.position, Quaternion.identity, transform);
            if (materialY != null){
                meshRenderer.material = materialY;
                skinRenderer.materials[0] = materialB;
                skinRenderer.materials[1] = materialW;
                
            }
        }
    }
    public GameObject particle;
    public Vector3 particlePosition;
}
