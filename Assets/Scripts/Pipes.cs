using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    //triggerenter2d method will be envoked when anything passes through the box collider.
private void OnTriggerEnter2D(Collider2D other)
{
    if(other.GetComponent<Handicap>() != null)
    GameControll.Instance.Score();
}
}
