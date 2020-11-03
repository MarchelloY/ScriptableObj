using UnityEngine;

namespace Chess.Controllers
{
    public class SpawnFigures : MonoBehaviour
    {
        [SerializeField] private BoardCells boardCells;
        
        private void Start()
        {
            var cells = boardCells.Cells;
            foreach (var cell in cells)
            {
                var go = Instantiate(cell.Figure.Prefab, cell.PosCell, Quaternion.identity);
                var isBlack = cell.TeamColor == FigureColor.Black;
                go.GetComponent<Renderer>().material = 
                    isBlack ? cell.Figure.Skins[1] : cell.Figure.Skins[0];
                if (isBlack) go.transform.Rotate(0,180f,0);
            }
        }
    }
}