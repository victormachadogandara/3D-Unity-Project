using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float movespeed;
    Animator anim;

    private void Awake() 
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        transform.Translate(Axis.normalized.magnitude * Vector3.forward * movespeed * Time.deltaTime);

        if (Axis != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(Axis.normalized);
        }

        anim.SetFloat("move", Mathf.Abs(Axis.normalized.magnitude));
    }

    Vector3 Axis
    {
        get => new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }
}
