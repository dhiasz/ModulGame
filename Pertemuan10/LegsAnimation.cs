using System.Collections;
using System.Collections.Generic;
using TopDown.Movement;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class LegsAnimation : MonoBehaviour
{
    [SerializeField] private Move playermove;
    private Animator legsAnimator;
    

    private void Awake()
    {
        legsAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        legsAnimator.SetBool("Moving", playermove.CurrentInput != Vector3.zero);
    }
}
