using UnityEngine;

namespace Chess
{
    [CreateAssetMenu(fileName = "BoardCells", menuName = "Chess/BoardCells", order = 0)]
    public class BoardCells : ScriptableObject
    {
        [SerializeField] private Cell[] cells;

        public Cell[] Cells => cells;
    }
}