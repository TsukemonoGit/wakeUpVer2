using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class husen : MonoBehaviour
{
    public GameObject target;
    public GameObject[] objs;
    public Vector3 interval = new Vector3(0,0.5f,0);
    public Vector3 setAnchor;
    public Vector3 setAxis;

    public Material ropeMaterial;
    LineRenderer line;
   // int hokan = 2;//Lineのかずふやす
 //   int lineLength;
     int objsLength;
 //   Vector3[] points;

    private void Start()
    {
        line = GetComponent<LineRenderer>();
        line.material = ropeMaterial;
        objsLength = objs.Length;
        //    lineLength = objsLength * hokan - 1;
        line.positionCount = objsLength;// lineLength;
        
    }

    private void Update()
    {
      //  ObjToLinePoint();
        LineView();
    }
    //void ObjToLinePoint()
    //{
    //    int index = 0;
    //    points = new Vector3[lineLength];
    //    for (int i = 0; i < objsLength; i++)
    //    {
    //        points[index] = objs[i].transform.position;
    // if(i==objsLength - 1) { break; }
    //        index++;
    //        points[index] = (objs[i + 1].transform.position - objs[i].transform.position) / 2f + objs[i].transform.position;
    //        index++;
    //    }
    //    Debug.Log(points[0]);
    //}

    private void LineView()
    {
        //for (int i = 0; i < lineLength; i++)
        //{
        //    line.SetPosition(i, points[i]);
        //}
        for (int i = 0; i < objsLength; i++)
        {
            line.SetPosition(i, objs[i].transform.position);
        }

    }

    [ContextMenu("ならべる")]
    public void SetPos()
    {
        for(int i = 0; i < objs.Length; i++)
        {
            objs[i].transform.localPosition = Vector3.zero +  interval*i;
        }
    }
    [ContextMenu("こんふぃぐあぶるジョイントつける")]
    public void SetJoint ()
    {
        for (int i = 0; i < objs.Length; i++)
        {

            ConfigurableJoint joint = objs[i].GetComponent<ConfigurableJoint>();
            if (joint == null) {
                objs[i].AddComponent<ConfigurableJoint>();
                joint = objs[i].GetComponent<ConfigurableJoint>();
            }
            if (i <objs.Length-1)
            {
                joint.connectedBody = objs[i + 1].GetComponent<Rigidbody>();
            }
            joint.anchor = setAnchor;
            joint.axis = setAxis;

        }
    }
    //[ContextMenu("meshRendererつける")]
    //public void SetMeshRen()
    //{
    //    for (int i = 0; i < objs.Length; i++)
    //    {

    //        MeshRenderer mesh = objs[i].GetComponent<MeshRenderer>();
    //        if (mesh == null)
    //        {
    //            objs[i].AddComponent<MeshRenderer>();
    //            //mesh = objs[i].GetComponent<MeshRenderer>();
    //        }
         
    //    }
    //}

}
