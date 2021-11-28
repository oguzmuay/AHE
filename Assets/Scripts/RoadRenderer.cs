using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadRenderer : MonoBehaviour
{
    private AppManager _appManager;

    private LineRenderer _roadRenderer;
    
    [SerializeField] private Texture2D roadTexture;
    // Start is called before the first frame update
    void Start()
    {
        _appManager = FindObjectOfType<AppManager>();
        _roadRenderer = FindObjectOfType<LineRenderer>();
        _roadRenderer.positionCount = _appManager.roadPositions.Count;
        for (int i = 0; i < _roadRenderer.positionCount; i++)
        {
            _roadRenderer.SetPosition(i,_appManager.roadPositions[i]);
        }
       // _roadRenderer.material.SetTexture("_MainTex", roadTexture);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < _roadRenderer.positionCount; i++)
        {
            Vector3 pos = new Vector3(_appManager.roadPositions[i].x,
                _appManager.roadPositions[i].y + _appManager.screenOffSetY);
            _roadRenderer.SetPosition(i, pos);
        }
    }
}
