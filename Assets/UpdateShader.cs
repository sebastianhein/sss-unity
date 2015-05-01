using UnityEngine;
using System.Collections;

public class UpdateShader : MonoBehaviour {

    public Light _light;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = _light.transform.position;
   

        GetComponent<MeshRenderer>().sharedMaterial.SetVector("_lightPosition", new Vector4(pos.x, pos.y, pos.z, 0));

	}
}
