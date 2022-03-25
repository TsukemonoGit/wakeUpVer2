using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HousyuuFanz : MonoBehaviour

{
    public GameObject housyuuFanz;
    public Transform parent;
   
    public void GohoubiFanz(int num ,Vector3 position)
    {
        for (int i = 0; i < num; i++)
        {
             Instantiate(housyuuFanz, position, Quaternion.identity, parent);
        }


    }
}
