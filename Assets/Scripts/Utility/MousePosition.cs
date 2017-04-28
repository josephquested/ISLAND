using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MousePosition {

   public static Vector3 Get ()
 	 {
     Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
     return Camera.main.ScreenToWorldPoint(mousePos);
 	 }
 }
