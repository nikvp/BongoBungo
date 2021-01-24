using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumFeedbackAnimation : MonoBehaviour
{
    public void CongaTap() {
        Animation animator = gameObject.GetComponent<Animation>();
        animator.Play();
    }
    public void DjembeTap() {
        Animation animator = gameObject.GetComponent<Animation>();
        animator.Play();
    }
    public void SteelTap() {
        Animation animator = gameObject.GetComponent<Animation>();
        animator.Play();
    }

}
