using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript : MonoBehaviour {
    [SerializeField] private float AgeLimit;
    float age;

    void Reset() {
        AgeLimit = 2.0f;
    }

    void Update() {
        if (age > AgeLimit) {
            Destroy(gameObject);
            return;
        }

        age += Time.deltaTime;
    }
}