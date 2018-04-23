using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Controls;

namespace TextEditPasswordStrengthBar
{
    //The attribute that points to the registration method 
    [UserRepositoryItem("RegisterTextEditPwdStrength")]
    class RepositoryItemTextEditPwdStrength : RepositoryItemTextEdit
    {
        private static readonly object editValueChanging = new object();

        // Static constructor should call registration method
        static RepositoryItemTextEditPwdStrength() { RegisterTextEditPwdStrength(); }

        public const string TextEditPwdStrengthName = "TextEditPwdStrength";
        public override string EditorTypeName { get { return TextEditPwdStrengthName; } }

        public static void RegisterTextEditPwdStrength()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(
                TextEditPwdStrengthName, typeof(TextEditPwdStrength), typeof(RepositoryItemTextEditPwdStrength),
                typeof(TextEditPwdStrengthViewInfo), new TextEditPwdStrengthPainter(), true));
        }
    }
}
