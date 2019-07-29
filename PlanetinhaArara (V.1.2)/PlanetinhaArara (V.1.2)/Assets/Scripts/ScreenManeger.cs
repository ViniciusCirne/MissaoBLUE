using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManeger : MonoBehaviour
{
   public Animator camShakeAnim;
   public Animator camHitAnim;


   public void CamShake() 
   
   {
       camShakeAnim.SetTrigger("shake");

   }

   public void CamHit() 
   
   {
       camHitAnim.SetTrigger("hit");

   }




}
