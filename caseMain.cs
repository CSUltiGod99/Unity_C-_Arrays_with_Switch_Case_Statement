// CSharp Unity Arrays With A Switch Case Statement:

// source code:

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdditArrays : MonoBehaviour
{

  void Start()
  {

  }
  
  void Update()
  {
    string[] wordMe = { "me", "myself", "i" };

for (int i = 0; i < wordMe.Length; i++)
{
   switch (wordme[i])
   {
      case "me" when i == 0:
         Me("me"); //refers to method
         break;
      case "myself" when i == 1:
         Myself("myself"); //refers to method
         break;
      case "i" when i == 2:
         I("i"); //refers to method
         break;
      default:
         break;

   }
}
  
}

