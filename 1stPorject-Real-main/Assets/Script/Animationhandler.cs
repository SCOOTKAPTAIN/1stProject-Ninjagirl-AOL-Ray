using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationhandler : MonoBehaviour
{
    private Animator m_animator; 
    
    void Start()
    {
        m_animator = GetComponent<Animator>();
    }

    
   public void PlayerAttack()
    {
        m_animator.SetTrigger("goAttack");
    }

    void Update ()
    {
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            m_animator.SetTrigger("goAttack");
        }


    }


}
