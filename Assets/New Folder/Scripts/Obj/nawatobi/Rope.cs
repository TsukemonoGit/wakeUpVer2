using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    public float rope_Len;
    public float rope_Sphere_Scale;
    public Material material;
    public GameObject[] vertices = new GameObject[20];
    LineRenderer line;
    Rotate rotateR;
    Rotate rotateL;
    public int myNum;
    string myString;
    float myPosY;
    public nawatobiManager nawaMane;
    void Start()
    {
        line = GetComponent<LineRenderer>();
        line.material = material;// new Material(Shader.Find("Unlit/Color"));
        line.positionCount = vertices.Length;

        foreach (GameObject v in vertices)
        {
            v.GetComponent<MeshRenderer>().enabled = false;
        }
        rotateR = vertices[0].GetComponent<Rotate>();
        rotateL = vertices[vertices.Length - 1].GetComponent<Rotate>();
        rotateL.enabled = false;
        rotateR.enabled = false;
        myString = "なわとび" + myNum;
        myPosY = 100 + myNum * 50;
    }

    void Update()
    {
        int idx = 0;
        foreach (GameObject v in vertices)
        {
            line.SetPosition(idx, v.transform.position);
            idx++;
        }
    }

    [ContextMenu("ロープの長さ、キューブのスケール変更")]
    public void SetRope()
    {
        float interval=rope_Len / (vertices.Length - 1 );
        for (int i = 0; i < vertices.Length; i ++)
        {
            vertices[i].gameObject.transform.localScale = Vector3.one*rope_Sphere_Scale;
            vertices[i].transform.localPosition = transform.localPosition + Vector3.right * i  * interval;
       //     vertices[i].GetComponent<HingeJoint>().connectedAnchor =-Vector3.right * interval/2;
        }
    }
    //void OnGUI()
    //{
    //    if (GUI.Button(new Rect(20, myPosY, 150, 45),myString ))
    //    {
    //        if (rotateL.enabled)
    //        {
    //            rotateL.enabled = false;
    //            rotateR.enabled = false;
    //        }
    //        else
    //        {
    //            rotateL.enabled = true;
    //            rotateR.enabled = true;

    //        }

    //    }
        
    //}
    public void OnClickButton()
    {
        //回ってる時、とめる
        if (rotateL.enabled)
        {
            rotateL.enabled = false;
            rotateR.enabled = false;
            nawaMane.messageNum = 0;
        }
        //回ってない時、まわす
        else
        {
            rotateL.enabled = true;
            rotateR.enabled = true;
            nawaMane.messageNum = 1;

        }

    }
}