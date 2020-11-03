using UnityEngine;

namespace Chess
{
    [CreateAssetMenu(fileName = "FigureMoves", menuName = "Chess/FigureMoves", order = 0)]
    public class FigureMoves : ScriptableObject
    {
        [SerializeField] private Vector2[] moves;

        public Vector2[] Moves => moves;
    }
}