using UnityEngine;
using UnityEngine.Events;

public class VRUIOperation : MonoBehaviour
{
    public UnityEvent OnEnter;
    public UnityEvent OnExit;

    private void OnTriggerEnter(Collider other)
    {
        TrigExit.instance.currentCollider = GetComponent<VRUIOperation>();
        OnEnter.Invoke();
    }
}
