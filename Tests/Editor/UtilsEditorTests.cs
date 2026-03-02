using NUnit.Framework;
using UnityEngine;
using AnkleBreaker.Utils.Editor;

namespace AnkleBreaker.Utils.Editor.Tests
{
    public class UtilsEditorTests
    {
        #region MonoScriptFinder

        [Test]
        public void MonoScriptFinder_FindExistingClass_ReturnsNotNull()
        {
            // MonoBehaviour exists in every Unity project
            var script = MonoScriptFinder.FindMonoScriptByClassName("MonoScriptFinder");
            Assert.IsNotNull(script);
        }

        [Test]
        public void MonoScriptFinder_FindNonExistentClass_ReturnsNull()
        {
            var script = MonoScriptFinder.FindMonoScriptByClassName("ThisClassDoesNotExist_XYZ_999");
            Assert.IsNull(script);
        }

        #endregion

        #region AB_Gizmos

        [Test]
        public void DrawWireframeBox_DoesNotThrow()
        {
            Assert.DoesNotThrow(() =>
            {
                AB_Gizmos.DrawWireframeBox(Vector3.zero, Quaternion.identity, Vector3.one, Color.red);
            });
        }

        [Test]
        public void DrawCapsule_WithPosition_DoesNotThrow()
        {
            Assert.DoesNotThrow(() =>
            {
                AB_Gizmos.DrawCapsule(Vector3.zero, Quaternion.identity, 0.5f, 2f, Color.green);
            });
        }

        [Test]
        public void DrawCapsule_NullCollider_DoesNotThrow()
        {
            Assert.DoesNotThrow(() =>
            {
                AB_Gizmos.DrawCapsule((CapsuleCollider)null, Color.blue);
            });
        }

        #endregion

        #region TextInputDialogWindow

        [Test]
        public void TextInputDialogWindow_TypeExists()
        {
            var type = typeof(TextInputDialogWindow);
            Assert.IsNotNull(type);
            Assert.IsTrue(type.IsSubclassOf(typeof(UnityEditor.EditorWindow)));
        }

        #endregion
    }
}
