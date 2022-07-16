
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;
    public Transform obstruction;
    public float smoothSpeed = 0.12f;

    public Vector3 offset;

    //public LeanFade leanFade;

    void LateUpdate()
    {
        transform.position = target.position + offset;
    }

    private void Start()
    {
        obstruction = target;

    }

    void viewObstructed()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, target.position - transform.position, out hit))
        {
            if (hit.collider.gameObject.tag != "Player")
            {
                //obstruction = hit.transform;
                //obstruction.gameObject.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                //leanFade.OnTriggerEnter();
            }
            else
            {
                //obstruction.gameObject.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            }

        }
    }


}
