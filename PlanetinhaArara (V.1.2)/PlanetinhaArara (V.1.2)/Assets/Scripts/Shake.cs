﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
   public Animator camShakeAnim;

   public void CamShake() 
   
   {
       camShakeAnim.SetTrigger("shake");

   }




}
