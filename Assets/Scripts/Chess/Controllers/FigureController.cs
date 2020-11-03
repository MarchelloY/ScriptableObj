using UnityEngine;

namespace Chess.Controllers
{
    public class FigureController : MonoBehaviour
    {
        [SerializeField] private Figure[] figures;
        [SerializeField] private Camera mainCamera;

        private void Update()
        {
            if (!Input.GetMouseButton(0)) return;
            var ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (!Physics.Raycast(ray, out var hit)) return;
            var pos = hit.collider.transform.position; //Current cell pos
        }
    }
}