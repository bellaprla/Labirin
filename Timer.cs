using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class Timer : MonoBehaviour
{
    [SerializeField] TMPro.TMP_Text tmpText;
    public UnityEvent OnStart;
    public UnityEvent OnEnd;

    private void Start()
    {
        OnStart.Invoke();
        var sequence = DOTween.Sequence();
        tmpText.transform.localScale = Vector3.zero;
        tmpText.text = "20";
        sequence.Append(tmpText.transform.DOScale(
            Vector3.one,
            1).OnComplete(() => 
            {
                tmpText.transform.localScale = Vector3.zero;
                tmpText.text = "19";
            }));
        sequence.Append(tmpText.transform.DOScale(
            Vector3.one,
            1).OnComplete(() => 
            {
                tmpText.transform.localScale = Vector3.zero;
                tmpText.text = "18";
            }));
        sequence.Append(tmpText.transform.DOScale(
            Vector3.one,
            1).OnComplete(() => 
            {
                tmpText.transform.localScale = Vector3.zero;
                tmpText.text = "17";
                OnEnd.Invoke();
            }));
        sequence.Append(tmpText.transform.DOScale(
            Vector3.one,
            1).OnComplete(() => 
            {
                tmpText.transform.localScale = Vector3.zero;
                tmpText.text = "16";
                OnEnd.Invoke();
            }));
        sequence.Append(tmpText.transform.DOScale(
            Vector3.one,
            1).OnComplete(() => 
            {
                tmpText.transform.localScale = Vector3.zero;
                tmpText.text = "15";
                OnEnd.Invoke();
            }));
        sequence.Append(tmpText.transform.DOScale(
            Vector3.one,
            1).OnComplete(() => 
            {
                tmpText.transform.localScale = Vector3.zero;
                tmpText.text = "14";
                OnEnd.Invoke();
            }));
        sequence.Append(tmpText.transform.DOScale(
            Vector3.one,
            1).OnComplete(() => 
            {
                tmpText.transform.localScale = Vector3.zero;
                tmpText.text = "13";
                OnEnd.Invoke();
            }));
        sequence.Append(tmpText.transform.DOScale(
            Vector3.one,
            1).OnComplete(() => 
            {
                tmpText.transform.localScale = Vector3.zero;
                tmpText.text = "12";
                OnEnd.Invoke();
            }));
        sequence.Append(tmpText.transform.DOScale(
            Vector3.one,
            1).OnComplete(() => 
            {
                tmpText.transform.localScale = Vector3.zero;
                tmpText.text = "11";
                OnEnd.Invoke();
            }));
        sequence.Append(tmpText.transform.DOScale(
            Vector3.one,
            1).OnComplete(() => 
            {
                tmpText.transform.localScale = Vector3.zero;
                tmpText.text = "10";
                OnEnd.Invoke();
            }));
        sequence.Append(tmpText.transform.DOScale(
            Vector3.one,
            1).OnComplete(() => 
            {
                tmpText.transform.localScale = Vector3.zero;
                tmpText.text = "9";
                OnEnd.Invoke();
            }));
        sequence.Append(tmpText.transform.DOScale(
            Vector3.one,
            1).OnComplete(() => 
            {
                tmpText.transform.localScale = Vector3.zero;
                tmpText.text = "8";
                OnEnd.Invoke();
            }));
        sequence.Append(tmpText.transform.DOScale(
            Vector3.one,
            1).OnComplete(() => 
            {
                tmpText.transform.localScale = Vector3.zero;
                tmpText.text = "7";
                OnEnd.Invoke();
            }));
        sequence.Append(tmpText.transform.DOScale(
            Vector3.one,
            1).OnComplete(() => 
            {
                tmpText.transform.localScale = Vector3.zero;
                tmpText.text = "6";
                OnEnd.Invoke();
            }));
        sequence.Append(tmpText.transform.DOScale(
            Vector3.one,
            1).OnComplete(() => 
            {
                tmpText.transform.localScale = Vector3.zero;
                tmpText.text = "5";
                OnEnd.Invoke();
            }));
        sequence.Append(tmpText.transform.DOScale(
            Vector3.one,
            1).OnComplete(() => 
            {
                tmpText.transform.localScale = Vector3.zero;
                tmpText.text = "4";
                OnEnd.Invoke();
            }));
        sequence.Append(tmpText.transform.DOScale(
            Vector3.one,
            1).OnComplete(() => 
            {
                tmpText.transform.localScale = Vector3.zero;
                tmpText.text = "3";
                OnEnd.Invoke();
            }));
        sequence.Append(tmpText.transform.DOScale(
            Vector3.one,
            1).OnComplete(() => 
            {
                tmpText.transform.localScale = Vector3.zero;
                tmpText.text = "2";
                OnEnd.Invoke();
            }));
        sequence.Append(tmpText.transform.DOScale(
            Vector3.one,
            1).OnComplete(() => 
            {
                tmpText.transform.localScale = Vector3.zero;
                tmpText.text = "1";
                OnEnd.Invoke();
            }));
        sequence.Append(tmpText.transform.DOScale(
            Vector3.one,
            1).OnComplete(() => 
            {
                tmpText.transform.localScale = Vector3.zero;
                tmpText.text = "0";
                OnEnd.Invoke();
            }));
    }
}