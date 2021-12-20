using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delay : MonoBehaviour
{
    void Start(){Invoke("e",2);}void e(){GameObject.FindObjectOfType<sound>(true).gameObject.SetActive(true);}
}