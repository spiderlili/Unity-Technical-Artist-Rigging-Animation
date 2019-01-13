using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour {
    Image image;
    [SerializeField] private float fillSpeed = 0.1f; //the fill amount increments per second.

    void Start () {
        image = GetComponent<Image>();
	}
	
	void Update () {
        image.fillAmount += Time.deltaTime * fillSpeed;

    }
}
