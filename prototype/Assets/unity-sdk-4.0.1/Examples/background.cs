using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    // Start is called before the first frame update
    public float scroll_speed = 0.1f;
    private MeshRenderer mesh_Renderer;
    private Vector2 save_Offset;
    void Awake()
    {
        mesh_Renderer = GetComponent<MeshRenderer>();
        save_Offset = mesh_Renderer.sharedMaterial.GetTextureOffset("_MainTex");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Time.time * scroll_speed;
        Vector2 offset = new Vector2(x, 0);
        mesh_Renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
    private void OnDisable()
    {
        mesh_Renderer.sharedMaterial.SetTextureOffset("_MainTex", save_Offset);
    }
}
