#if UNITY_EDITOR
using UnityEditor;
#else
using UnityEngine;
#endif

/// <summary>
/// Unity game application namespace
/// </summary>
namespace UnityGameApplication
{
    /// <summary>
    /// A class that describes a set of functions for a game application
    /// </summary>
    public static partial class GameApplication
    {
        /// <summary>
        /// Quits game application
        /// </summary>
        public static void Quit()
        {
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
    }
}
