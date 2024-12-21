using System.Diagnostics;
using Debug = UnityEngine.Debug;

namespace Singular
{
    static class SingularUnityLogger
    {
        const string _tag = "[Singular] ";

        [Conditional("DEBUG")]
        public static void LogDebug(string message)
        {
            Debug.Log(_tag + message);
        }

        [Conditional("DEBUG")]
        public static void LogWarn(string message)
        {
            Debug.LogWarning(_tag + message);
        }

        public static void LogError(string message)
        {
            Debug.LogError(_tag + message);
        }
    }
}