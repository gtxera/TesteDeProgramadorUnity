using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardText : MonoBehaviour
{
    [SerializeField] private GameObject ParentObject, ARCamera;
    
    private RectTransform _rectTransform;
    
    void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        var direction = (ARCamera.transform.position - ParentObject.transform.position).normalized;

        var rotation = Quaternion.LookRotation(direction);
        
        _rectTransform.rotation = Quaternion.Euler(0, rotation.eulerAngles.y + 180, 0);
    }
}
