using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Goal  に入ったファンズをファンズリストに追加して、Nowfollowingから外す
public class EnterCheck : MonoBehaviour
{
    public GameController gameCon;
    public List<GameObject> fanzList=new List<GameObject>();
    private void OnTriggerEnter(Collider other)
    {
       
       // DoFollow fanzFollow = other.GetComponent<DoFollow>();
        //if (fanzFollow != null )
        {

            // GameObject fanz = fanzFollow.transform.parent.gameObject;
            FanzController fanz = other.GetComponent<FanzController>();
            if (fanz != null)
            {
                Debug.Log(other);
                for (int j = 0; j < gameCon.nowFollowings.Count; j++)
                {
                  
                    if (fanz.gameObject == gameCon.nowFollowings[j])
                    {
                        gameCon.nowFollowings.RemoveAt(j);
                        fanzList.Add(fanz.gameObject);
                    }

                }
            }
        }
    }
}
