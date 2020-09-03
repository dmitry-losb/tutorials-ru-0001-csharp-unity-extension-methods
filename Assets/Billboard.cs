using UnityEngine;

public class Billboard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = Vector3.one;
        int number = 10;
        
        number.Test();
        position.Test();
        
        if (Input.GetMouseButtonDown(0))
        {
            this.Deactivate();
        }
    }
}