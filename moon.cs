using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class moon : MonoBehaviour
{
	
	public Vector2 velocity = new Vector2(1,0);
	
	[Range(0,5)]
	public float rotateSpeed = 1f;
	[Range(0,5)]
	public float rotateRadiusX = 1f;
	[Range(0,5)]
	public float rotateRadiusY = 1f;
	
	public bool Clockwise = true;
	
	private Vector2 _centre;
	private float _angle;
	
    // Start is called before the first frame update
    private void Start()
    {
        _centre = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        _centre += velocity * Time.deltaTime;
		
		_angle += (Clockwise ? rotateSpeed : -rotateSpeed) * Time.deltaTime;
		
		var x = Mathf.Sin(_angle) * rotateRadiusX;
		var y = Mathf.Cos(_angle) * rotateRadiusY;
		
		transform.position = _centre + new Vector2(x, y);
    }
}
*/



public class moon : MonoBehaviour
{
	
	private float rotateSpeed = .5f;
	private float radius = 2f;
	
	private Vector2 _centre;
	private float _angle;
	
    // Start is called before the first frame update
    private void Start()
    {
        _centre = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        _angle += rotateSpeed * Time.deltaTime;
		
		var offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * radius;
		//var offset = new Vector2(_angle, _angle);
		transform.position = _centre + offset;
    }
}