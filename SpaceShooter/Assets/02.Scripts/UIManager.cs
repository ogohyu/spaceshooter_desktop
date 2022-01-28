using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class UIManager : MonoBehaviour
{
    public Button startButton;
    public Button optionButton;
    public Button shopButton;

    private UnityAction action;

    // Start is called before the first frame update
    void Start()
    {
        action = () => OnButtonClick(startButton.name);
        startButton.onClick.AddListener(action);

        optionButton.onClick.AddListener(delegate { OnButtonClick(optionButton.name); });

        shopButton.onClick.AddListener(()=> OnButtonClick(shopButton.name));
    }

    public void OnButtonClick(string msg)
    {
        Debug.Log($"Click Button : {msg}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
