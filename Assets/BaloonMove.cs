using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BaloonMove : MonoBehaviour
{

    public Animator _animator;
//    public bool AnimationLeftFlag;
//    public bool AnimationRightFlag;
//    public float MouseXPosition;

    // Use this for initialization
    void Start()
    {
        _animator = GetComponent<Animator>();//BaloonSprite

        StartAnimation();
        GlobalVariables.AnimationIdleFlag = false;
        GlobalVariables.AnimationLeftFlag = false;
        GlobalVariables.AnimationRightFlag = false;
        /*
                _animator.SetBool("LeftFlag", false);
                _animator.SetBool("IdleFlag", true);
                _animator.SetBool("IdleFlag2", true);
                _animator.SetBool("RightFlag", false);
                _animator.SetBool("DownFlag", false);
        */
        _animator.SetBool("LeftFlag", true);
        _animator.SetBool("IdleFlag", false);
        _animator.SetBool("IdleFlag2", false);
        _animator.SetBool("RightFlag", false);
        _animator.SetBool("DownFlag", false);


    }

    // Update is called once per frame
    void Update()
    {
/*
        _animator.SetBool("LeftFlag", false);
        _animator.SetBool("IdleFlag", true);
        _animator.SetBool("IdleFlag2", true);
        _animator.SetBool("RightFlag", false);
        _animator.SetBool("DownFlag", false);
*/
        if (GlobalVariables.AnimationIdleFlag == false)
        {
            _animator.SetBool("LeftFlag", true);
            _animator.SetBool("IdleFlag", false);
            _animator.SetBool("IdleFlag2", false);
            _animator.SetBool("RightFlag", false);
            _animator.SetBool("DownFlag", false);

        }


        if ( GlobalVariables.AnimationLeftFlag == true )
        {
            ChangeAnimationLeft();
        }
/*
        if (GlobalVariables.AnimationRightFlag == true)
        {
            ChangeAnimationRight();
        }
*/
        Debug.Log("AnimationLeftFlag:" + GlobalVariables.AnimationLeftFlag);
        Debug.Log("AnimationIdleFlag:" + GlobalVariables.AnimationIdleFlag);

    }
    public void StartAnimation()
    {

        if ( ( GlobalVariables.AnimationLeftFlag == false ) || ( GlobalVariables.AnimationRightFlag == false ) )
        {

            _animator.SetBool("IdleFlag", true);

        }

    }

    public void ChangeAnimationLeft()
    {
        if (GlobalVariables.AnimationLeftFlag == true)
        {
            //ele1->ele2に切り替える
  //          _animator.SetBool("BaloonRightFlag", false);
//            _animator.SetBool("BaloonSpriteIdle", false);
            _animator.SetBool("LeftFlag", true);
            _animator.SetBool("IdleFlag", false);
            _animator.SetBool("IdleFlag2", false);
            _animator.SetBool("RightFlag", false);
            _animator.SetBool("DownFlag", false);

//            GlobalVariables.AnimationLeftFlag = false;
        }
        /*
        else
        {
            //ele1->ele2に切り替える
            _animator.SetBool("BaloonRightFlag", false);
//            _animator.SetBool("BaloonSpriteIdle", false);
            _animator.SetBool("BaloonLeftFlag", false);
            GlobalVariables.AnimationLeftFlag = false;
        }
        */
    }
/*
    public void ChangeAnimationRight()
    {
        if (GlobalVariables.AnimationRightFlag == true)
        {
            //ele1->ele2に切り替える
            _animator.SetBool("BaloonRightFlag", true);
            _animator.SetBool("BaloonSpriteIdle", false);
            _animator.SetBool("BaloonLeftFlag", false);
            GlobalVariables.AnimationRightFlag = false;
        }
        else
        {
            //ele1->ele2に切り替える
            _animator.SetBool("BaloonRightFlag", false);
            _animator.SetBool("BaloonSpriteIdle", false);
            _animator.SetBool("BaloonLeftFlag", false);
            GlobalVariables.AnimationRightFlag = false;
        }

    }
*/
}
