using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;

public class SceneNameText : MonoBehaviour
{
    TextMeshProUGUI SceneName;
    void Start()
    {
        SceneName = GetComponent<TextMeshProUGUI>();
        SceneName.text = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
