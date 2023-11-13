using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyPhysics : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    private GameObject presser;
    AudioSource sound;
    public bool isPressed;

    void Start() {
        sound = GetComponent<AudioSource>();
        isPressed = false;
    }

    private void OnTriggerEnter(Collider other) {
        if (!isPressed) {
            button.transform.localPosition = new Vector3(0, 0, 0.0025f);
            presser = other.gameObject;
            onPress.Invoke();
            sound.Play();
            Debug.Log("Button press is registered");
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject == presser) {
            button.transform.localPosition = new Vector3(0, 0, 0.009f);
            onRelease.Invoke();
            isPressed = false;
        }
    }
}