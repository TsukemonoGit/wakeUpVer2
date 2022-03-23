
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayerToObj : MonoBehaviour
{
    public Transform buranco;
    public bool isActive;
   Transform constraint;
    public PlayerController con;
    public float limitRotate = 60;
    public GameObject CinemachineCameraTarget;
    public float wariai = 0.5f;
    public SubCameraCon subCamera;
    public CharacterController characon;
    //public void SetPlayerToBuranco()
    //{
    //    constraint=buranco;
    //}
    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            transform.position = constraint.position;
            //           //  transform.rotation = constraint.transform.rotation;
            //           Quaternion quaternion;
            //           quaternion.x = 0;       //Mathf.Lerp(transform.rotation.x, constraint.rotation.x, wariai);
            //           quaternion.y = constraint.rotation.y;       // Mathf.Lerp(transform.rotation.y, constraint.rotation.y, wariai);
            ////           quaternion.z = Mathf.Clamp( constraint.rotation.z, -0.4f,0.4f);
            //           quaternion.z = Mathf.Clamp(Mathf.Lerp(transform.rotation.z, constraint.rotation.z, wariai), -0.4f, 0.4f);

            //           quaternion.w = 0;           // Mathf.Lerp(transform.rotation.w, constraint.rotation.w, wariai);
            //           transform.rotation = quaternion;
            transform.rotation = constraint.rotation;
          //  Debug.Log(quaternion);
   
        }
    }
    public void SetActive(bool _isActive)
    {
        constraint = buranco;
        transform.rotation = constraint.rotation;
        isActive = _isActive;
        con.enabled = !_isActive;
        characon.enabled = !_isActive;
        subCamera.SetSubCamera(_isActive);
        CinemachineCameraTarget.transform.rotation = transform.rotation;
    }
}
