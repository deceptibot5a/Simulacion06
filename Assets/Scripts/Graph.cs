using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField] GameObject mPrefab;
    [SerializeField] int mTotalPoints = 10;
    [SerializeField] float mDistanceFactor = 1;
    [SerializeField] float mAmplitude = 1;
    //[SerializeField] LineRenderer mLineRenderer;
    private GameObject[] mAllPoints;

    private void Start() {
        //mLineRenderer = GetComponent<LineRenderer>();
        //mLineRenderer.positionCount = mTotalPoints;
;       mAllPoints = new GameObject[mTotalPoints];
        for (int i = 0; i < mTotalPoints; i++) {
            mAllPoints[i] = Instantiate(mPrefab, transform);
        }
    }
    private void Update() {
        for (int i = 0; i < mAllPoints.Length; i++) {
            float x = i * mDistanceFactor;
            float y = F(x);
            //mLineRenderer.SetPosition(i, new Vector3(x, y));
            mAllPoints[i].transform.localPosition = new Vector3(x, y, 0);
        }
        float F(float x) => mAmplitude * Mathf.Sin(x + Time.time);
    }
}
