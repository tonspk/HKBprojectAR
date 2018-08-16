using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadScene : MonoBehaviour {
		public void numScence(int sceneNumber) {
      Application.LoadLevel(sceneNumber);
    }
}